using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtpNet;
using QRCoder;

namespace Dropify
{
    public partial class SecurityUI : BaseForm
    {
        private string connectionString = Properties.Settings.Default.ConnectionString;
        private string email;
        private Guid profileID;
        private string base32SecretKey;
        private string uriString;
        private bool isAnsEmpty;
        private int launchWindow; // 0 - SignUp, 1 - SignIn, 2- Manager


        public SecurityUI(Guid ProfileID, string Email, int parentWindow)
        {
            InitializeComponent();
            InitializeTitlebar();
            
            cbxSecurityQues.SelectedIndex = 0;
            email = Email;
            profileID = ProfileID;
            launchWindow = parentWindow;
            InitializeSecrets();
            GenerateQR();


        }
        private void InitializeTitlebar()
        {
            base.TitlebarColorInt = 1939711;
            base.BorderColorInt = 1939711;
            base.WindowCorner = 3;
        }


        public void InitializeSecrets()
        {
            var keyLength = 20;
            var secretKey = KeyGeneration.GenerateRandomKey(keyLength);
            var base32Secret = Base32Encoding.ToString(secretKey);
            var issuer = "Dropify";
            var accountName = email;

            base32SecretKey = base32Secret;
            uriString = new OtpUri(OtpType.Totp, base32Secret, accountName, issuer).ToString();
        }
        private void GenerateQR()
        {
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(uriString, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(64);

            pictureBox1.Image = qrCodeImage;
        }
        private void tbxSecurityAns_TextChanged(object sender, EventArgs e)
        {
            isAnsEmpty = string.IsNullOrWhiteSpace(tbxSecurityAns.Text);
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (VerifyOTP(tbxOTP.Text))
            {
                MessageBox.Show("Verification successful!", "OTP");
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Verification failed. Please try again with a new code.","OTP");
                btnSave.Enabled = false;
            };
        }
        private bool VerifyOTP(string userOTP)
        {
            var totp = new Totp(Base32Encoding.ToBytes(base32SecretKey));
            return totp.VerifyTotp(userOTP, out _, VerificationWindow.RfcSpecifiedNetworkDelay);
        }


        public bool AddSecurityInfo()
        {
            try
            {
                string query = "UPDATE Login SET Secret = @Secret, SecurityQues = @SecurityQues, SecurityAns = @SecurityAns, ProfileStatus = @ProfileStatus WHERE ProfileID = @ProfileID"; ;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProfileID", profileID);
                        command.Parameters.AddWithValue("@Secret", base32SecretKey);
                        command.Parameters.AddWithValue("@SecurityQues", cbxSecurityQues.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@SecurityAns", tbxSecurityAns.Text);
                        command.Parameters.AddWithValue("@ProfileStatus", "Activated");

                        int rowsAffected = command.ExecuteNonQuery();

                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Security Info Updated Successfully.");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("There was an error. Let's start over.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAnsEmpty)
            {
                MessageBox.Show("Please fill up the security answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddSecurityInfo();
                Router();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("If you go back now you will have to\n" +
                                                  "complete this verification the next\n" +
                                                  "time you log in. Your account will be\n" +
                                                  "on hold. Do you want to continue?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    Router();
                    this.Hide();
                    break;

                case DialogResult.No:
                    break;

                case DialogResult.Cancel:
                    break;
            }
        }

        private void Router()
        {
            if (launchWindow == 0)
            {
                SignupUI signupUI = new SignupUI();
                signupUI.Show();
            }
            else if (launchWindow == 1)
            {
                SigninUI signinUI = new SigninUI();
                signinUI.Show();
            }else if (launchWindow == 2)
            {
                //To-Do: Manager
            }
        }
    }
}
