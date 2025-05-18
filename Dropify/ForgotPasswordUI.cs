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

namespace Dropify
{
    public partial class ForgotPasswordUI : BaseForm
    {

        public string connectionString = Properties.Settings.Default.ConnectionString;
        public PasswordChangeUserControl passwordChange;
        public Guid profileID;
        public ForgotPasswordUI()
        {
            InitializeComponent();
            InitializeTitlebar();

            
        }

        private void InitializeTitlebar()
        {
            base.TitlebarColorInt = 1939711;
            base.BorderColorInt = 1939711;
            base.WindowCorner = 3;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SigninUI signinUI = new SigninUI();
            signinUI.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchUser(tbxEmail.Text);
        }

        private void SearchUser(string text)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Login WHERE (Email = @ProvidedEmail OR Phone = @ProvidedPhone)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProvidedEmail", tbxEmail.Text);
                        command.Parameters.AddWithValue("@ProvidedPhone", tbxEmail.Text);

                        int count = (int)command.ExecuteScalar();

                        connection.Close();

                        if (count == 1)
                        {
                            GetProfileStatus();
                        }
                        else
                        {
                            MessageBox.Show("Email/Phone or password is incorrect.", "Invalid credentials");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetProfileStatus()
        {
            string securityQues;
            string secret;
            
            try
            {
                string query = "SELECT Secret,SecurityQues,ProfileID FROM Login WHERE (Email = @ProvidedEmailOrPhone OR Phone = @ProvidedEmailOrPhone)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProvidedEmailOrPhone", tbxEmail.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                securityQues = reader["SecurityQues"] is DBNull ? string.Empty : reader["SecurityQues"].ToString();
                                secret = reader["Secret"] is DBNull ? string.Empty : reader["Secret"].ToString();
                                Guid profileID = (Guid)reader["ProfileID"];

                                SecurityLog.Add(profileID, "Attempted Password Reset");


                                if (secret != string.Empty || securityQues != string.Empty)
                                {
                                    pnlContent.Controls.Clear();
                                    passwordChange = new PasswordChangeUserControl(profileID);
                                    pnlContent.Controls.Add(passwordChange);
                                    passwordChange.Dock = DockStyle.Fill;
                                }
                                else if (secret == string.Empty && securityQues == string.Empty)
                                {
                                    DialogResult result = MessageBox.Show("Your security info was not verified.\nYou cannot reset your password.\nDo you want to verify your security info now?", "Security Info Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                    if (result == DialogResult.Yes)
                                    {
                                        SecurityUI securityUI = new SecurityUI(profileID, tbxEmail.Text, 1);
                                        securityUI.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("You can still verify your security info the next time you log in.");
                                    }



                                }

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ForgotPasswordUI_Load(object sender, EventArgs e)
        {
            tbxEmail.Focus();
        }
    }
}
