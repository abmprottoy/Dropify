using OtpNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dropify
{
    public partial class PasswordChangeUserControl : UserControl
    {
        public string connectionString = Properties.Settings.Default.ConnectionString;

        private string securityQues;
        private string securityAns;
        private string secret;
        private bool isPasswordEmpty = true;
        private bool isPasswordValid;
        private Guid userProfileID;
        Label lblSuccess = new System.Windows.Forms.Label();


        public PasswordChangeUserControl(Guid profileID)
        {
            InitializeComponent();
            
            userProfileID = profileID;

            RetrieveSecurityInfo(profileID);
        }

        private void RetrieveSecurityInfo(Guid profileID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Secret, SecurityQues, SecurityAns FROM Login WHERE ProfileID = @ProfileID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProfileID", profileID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            securityQues = reader["SecurityQues"] is DBNull ? string.Empty : reader["SecurityQues"].ToString();
                            securityAns = reader["SecurityAns"] is DBNull ? string.Empty : reader["SecurityAns"].ToString();
                            secret = reader["Secret"] is DBNull ? string.Empty : reader["Secret"].ToString();

                            tbxSecurityQues.Text = securityQues;
                        }
                        else
                        {
                            MessageBox.Show("There was a problem finding your security info.\nDid you updated your security info?");
                        }
                    }
                }
            }
        }
        #region Security Ans Check
        private void btnSecurityAnsVerify_Click(object sender, EventArgs e)
        {
            if(tbxSecurityAns.Text == string.Empty)
            {
                MessageBox.Show("No Security Answer", "Please provide your security answer first.");
            }
            else
            {
                if(tbxSecurityAns.Text == securityAns)
                {
                    MessageBox.Show("Correct Security Answer", "Your security answer has been verified.\n Please enter your new password.");
                    tbxPassword.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Incorrect Security Answer", "The answer you have provided does not match\nyour security answer. Please try again.");
                }
            }
        }

        #endregion

        #region OTP Check
        private void btnOTPVerify_Click(object sender, EventArgs e)
        {
            if (tbxOTP.Text == string.Empty)
            {
                MessageBox.Show("No OTP provided", "Please provide your OTP first.");
            }
            else
            {
                if (VerifyOTP(tbxOTP.Text))
                {
                    MessageBox.Show("Correct OTP", "Your OTP has been verified.\n Please enter your new password.");
                    tbxPassword.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Incorrect OTP", "The OTP you have provided is incorrect.\nPlease try again.");
                }
            }
        }

        private bool VerifyOTP(string userOTP)
        {
            byte[] secretBytes = Base32Encoding.ToBytes(secret);
            var totp = new Totp(secretBytes);
            return totp.VerifyTotp(userOTP, out _, VerificationWindow.RfcSpecifiedNetworkDelay);
        }

        #endregion

        #region Password Check

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            isPasswordEmpty = string.IsNullOrWhiteSpace(tbxPassword.Text);
            isPasswordValid = IsValidPassword(tbxPassword.Text);

            if (!isPasswordValid)
            {
                ttPasswordValid.ToolTipTitle = "Password Invalid";
                ttPasswordValid.Show("Password must:\n" +
                    " - Be at least 8 characters long\n" +
                    " - Contain at least one uppercase letter\n" +
                    " - Contain at least one lowercase letter\n" +
                    " - Contain at least one digit\n" +
                    " - Contain at least one of the special characters: @$!% *? &", tbxPassword, 30, 23, 5000);
            }

            if (!isPasswordEmpty && isPasswordValid)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }
        static bool IsValidPassword(string password)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&]).{8,}$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(password);
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isPasswordEmpty)
            {
                MessageBox.Show("Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!isPasswordValid)
            {
                MessageBox.Show("Invalid password format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if(!isPasswordEmpty && isPasswordValid)
            {
                UpdatePassword(tbxPassword.Text);
            }
        }

        private void UpdatePassword(string text)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Hash the new password before storing it in the database for security reasons
                    string hashedPassword = HashProvider.CalculateSHA256(text);

                    string query = "UPDATE Login SET PasswordHash = @PasswordHash WHERE ProfileID = @ProfileID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                        command.Parameters.AddWithValue("@ProfileID", userProfileID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            this.Controls.Clear();

                            // 
                            // lblSuccess
                            // 
                            this.lblSuccess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
                            this.lblSuccess.AutoSize = true;
                            this.lblSuccess.Font = new System.Drawing.Font("Segoe UI Semilight", 28F);
                            this.lblSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(115)))));
                            this.lblSuccess.Location = new System.Drawing.Point(125, 96);
                            this.lblSuccess.Name = "lblSuccess";
                            this.lblSuccess.Size = new System.Drawing.Size(772, 51);
                            this.lblSuccess.Text = "Your password has been updated successfully!";
                            this.Controls.Add(this.lblSuccess);

                        }
                        else
                        {
                            MessageBox.Show("Failed to update password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
