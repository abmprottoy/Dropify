﻿using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Dropify
{
    public partial class SigninUI : BaseForm
    {
        private Random random = new Random();
        private string connectionString = Properties.Settings.Default.ConnectionString;
        private string status = "Connecting...";

        public SigninUI()
        {
            InitializeComponent();
            base.TitlebarColorInt = 5119488;
            base.BorderColorInt = 5119488;
            base.WindowCorner = 3;

            LoadRandomImage();
            
        }


        private void LoadRandomImage()
        {
            int randomImageIndex = random.Next(1, 10);
            string imageName = "HeroImage" + randomImageIndex.ToString();

            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
        }


      






        #region Password Toggle
        private void btnPassToggle_Click(object sender, EventArgs e)
        {
            TogglePasswordReveal();
        }
        private void TogglePasswordReveal()
        {
            if (tbxPassword.PasswordChar == '●')
            {
                tbxPassword.PasswordChar = '\0';
                btnPassToggle.Text = "";
            }
            else
            {
                tbxPassword.PasswordChar = '●';
                btnPassToggle.Text = "";
            }
        }
        #endregion


        #region Server Connection Check
        /// <summary>
        /// Upon loading the form it should try to establish connection with database
        /// asynchronously so that this loading does not block UI Thread. await keeps
        /// a promise to retun the async task when done.
        /// </summary>
        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Asynchronously execute the database operation
                status = await GetServerStatus();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                status = "No response";
            }

            // Update the UI with the result
            UpdateStatus();
        }

        /// <summary>
        /// Asynchronus Task with a return type of string. This Task will return
        /// it has value or no value from the database without blocking the main
        /// form from running.
        /// </summary>
        /// <returns></returns>
        private async Task<string> GetServerStatus()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand($"SELECT Properties FROM System WHERE Item = 'ServerStatus'", connection))
                {
                    object result = await command.ExecuteScalarAsync();
                    return result?.ToString() ?? "No status available";
                    //Is the result null? If not do the ToString. ?? Null-collasing operator
                    //If the left side is actually null then return the string on the right.
                }
            }
        }

        /// <summary>
        /// Updates the StatusStrip Status Label
        /// </summary>
        private void UpdateStatus()
        {
            lblStatus.Text = status;
        }

        #endregion Server Connection Check

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignupUI signupForm = new SignupUI();
            signupForm.Show();
            this.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(status == "Connected" || tbxEmail.Text == "admin@dropify.com")
            {
                InitiateLogin();
            }
            
        }

        private void InitiateLogin()
        {
            string passwordHash = HashProvider.CalculateSHA256(tbxPassword.Text);
            
            try
            {
                string query = "SELECT COUNT(*) FROM Login WHERE (Email = @ProvidedEmail OR Phone = @ProvidedPhone) AND PasswordHash = @ProvidedPasswordHash";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProvidedEmail", tbxEmail.Text);
                        command.Parameters.AddWithValue("@ProvidedPhone", tbxEmail.Text);
                        command.Parameters.AddWithValue("@ProvidedPasswordHash", passwordHash);

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetProfileStatus()
        {
            try
            {
                string query = "SELECT ProfileStatus, ProfileID, Role FROM Login WHERE (Email = @ProvidedEmailOrPhone OR Phone = @ProvidedEmailOrPhone)";

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
                                string profileStatus = reader["ProfileStatus"] as string;
                                //Guid profileID = reader.GetGuid(reader.GetOrdinal("ProfileID"));
                                Guid profileID = (Guid)reader["ProfileID"];
                                string role = reader["Role"] as string;

                               
                                SecurityLog.Add(profileID, "Login");

                                if (Enum.TryParse(role, true, out SystemRole systemRole))
                                {
                                    if (profileStatus == "Activated")
                                    {
                                        HomescreenRouter(systemRole, profileID);
                                    }
                                    else if (profileStatus == "Not Activated")
                                    {
                                        SecurityScreenRouter(systemRole, profileID);
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



        private void SecurityScreenRouter(SystemRole role, Guid profileID)
        {
            switch (role)
            {
                case SystemRole.User:
                    SecurityUI securityUI = new SecurityUI(profileID, tbxEmail.Text, 1);
                    securityUI.Show();
                    this.Hide();
                    break;


                case SystemRole.DeliveryPerson:
                    
                    break;

                case SystemRole.Admin:
                    
                    break;

                default:

                    MessageBox.Show($"Undefined role: {role}.\nContact with the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void HomescreenRouter(SystemRole role, Guid profileID)
        {
            switch (role)
            {
                case SystemRole.User:
                    UserUI userUI = new UserUI(profileID);
                    userUI.Show();
                    this.Hide();
                    break;


                case SystemRole.DeliveryPerson:

                    break;

                case SystemRole.Admin:
                    AdminUI adminUI = new AdminUI(profileID);
                    adminUI.Show();
                    this.Hide();
                    break;

                default:

                    MessageBox.Show($"Undefined role: {role}.\nContact with the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            ForgotPasswordUI forgotPasswordUI = new ForgotPasswordUI();
            forgotPasswordUI.Show();
            this.Hide();
        }
    }
}
