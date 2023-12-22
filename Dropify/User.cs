using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dropify
{
    public class User
    {
        public Guid ProfileID { get; set; }
        public string PasswordHash { get; set; }
        private string Secret { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string CountryCode { get; set; }
        public string Phone { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public string ProfileStatus { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string GovtIDType { get; set; }
        public string GovtID { get; set; }
        public Address address { get; set; }



        private string connectionString = Properties.Settings.Default.ConnectionString;


        public bool UserSignUp(User user)
        {
            try
            {
                string query = "INSERT INTO Login (ProfileID,PasswordHash,Role,Email,CountryCode,Phone,ProfileStatus) VALUES (@ProfileID, @PasswordHash, @Role, @Email, @CountryCode, @Phone, @ProfileStatus)";

                user.ProfileStatus = "Not Activated";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProfileID", user.ProfileID);
                        command.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                        command.Parameters.AddWithValue("@Role", user.Role);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@CountryCode", user.CountryCode);
                        command.Parameters.AddWithValue("@Phone", user.Phone);
                        command.Parameters.AddWithValue("@ProfileStatus", user.ProfileStatus);


                        command.ExecuteNonQuery();

                        MessageBox.Show("Profile created successfully.");
                        return true;
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


    }

}