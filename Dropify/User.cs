using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        public Image ProfilePicture { get; set; }
        public string TimeZoneID { get; set; }
        public string Currency { get; set; }
        public DateTimeOffset UserSince { get; set; }




        private string connectionString = Properties.Settings.Default.ConnectionString;


        public bool UserSignUp(User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string profileQuery = "INSERT INTO Login (ProfileID, PasswordHash, Role, Email, CountryCode, Phone, ProfileStatus) VALUES (@ProfileID, @PasswordHash, @Role, @Email, @CountryCode, @Phone, @ProfileStatus)";
                    string addressQuery = "INSERT INTO Address (AddressID, Country, City, Area, ZIP, Landmark) VALUES (@AddressID, @Country, @City, @Area, @ZIP, @Landmark)";
                    string personalInfoQuery = "INSERT INTO PersonalInfo (ProfileID, ProfileImage, FirstName, LastName, DOB, Gender, Country, GovtIDType, GovtID, AddressID) VALUES (@ProfileID, @ProfileImage, @FirstName, @LastName, @DOB, @Gender, @Country, @GovtIDType, @GovtID, @AddressID)";
                    string userInfoQuery = "INSERT INTO UserInfo (ProfileID, TimeZoneID, Currency, UserSince) VALUES (@ProfileID, @TimeZoneID, @Currency, @UserSince)";

                    byte[] profilePictureByteArray;
                    using (MemoryStream stream = new MemoryStream())
                    {
                        ProfilePicture.Save(stream, ProfilePicture.RawFormat);
                        profilePictureByteArray = stream.ToArray();
                    }

                    user.ProfileStatus = "Not Activated";

                    user.TimeZoneID = TimeZoneInfoProvider.GetTimeZone(user.address.City);
                    user.Currency = CurrencyProvider.GetCurrency(user.address.Country);

                    using (SqlCommand profileCommand = new SqlCommand(profileQuery, connection, transaction))
                    {
                        profileCommand.Parameters.AddWithValue("@ProfileID", user.ProfileID);
                        profileCommand.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                        profileCommand.Parameters.AddWithValue("@Role", user.Role);
                        profileCommand.Parameters.AddWithValue("@Email", user.Email);
                        profileCommand.Parameters.AddWithValue("@CountryCode", user.CountryCode);
                        profileCommand.Parameters.AddWithValue("@Phone", user.Phone);
                        profileCommand.Parameters.AddWithValue("@ProfileStatus", user.ProfileStatus);


                        profileCommand.ExecuteNonQuery();

                        using (SqlCommand addressCommand = new SqlCommand(addressQuery, connection, transaction))
                        {
                            addressCommand.Parameters.AddWithValue("@AddressID", user.address.AddressID);
                            addressCommand.Parameters.AddWithValue("@Country", user.address.Country);
                            addressCommand.Parameters.AddWithValue("@City", user.address.City);
                            addressCommand.Parameters.AddWithValue("@Area", user.address.Area);
                            //addressCommand.Parameters.AddWithValue("@Address", null);
                            addressCommand.Parameters.AddWithValue("@ZIP", user.address.Zip);
                            addressCommand.Parameters.AddWithValue("@Landmark", user.address.Landmark);
                            //No office field needed because this is user sign up.

                            addressCommand.ExecuteNonQuery();
                        }

                        using (SqlCommand personalInfoCommand = new SqlCommand(personalInfoQuery, connection, transaction))
                        {
                            personalInfoCommand.Parameters.AddWithValue("@ProfileID", user.ProfileID);
                            personalInfoCommand.Parameters.AddWithValue("@ProfileImage", profilePictureByteArray);
                            personalInfoCommand.Parameters.AddWithValue("@FirstName", user.FirstName);
                            personalInfoCommand.Parameters.AddWithValue("@LastName", user.LastName);
                            personalInfoCommand.Parameters.AddWithValue("@DOB", user.DOB);
                            personalInfoCommand.Parameters.AddWithValue("@Gender", user.Gender);
                            personalInfoCommand.Parameters.AddWithValue("@Country", user.address.Country);
                            personalInfoCommand.Parameters.AddWithValue("@GovtIDType", user.GovtIDType);
                            personalInfoCommand.Parameters.AddWithValue("@GovtID", user.GovtID);
                            personalInfoCommand.Parameters.AddWithValue("@AddressID", user.address.AddressID);

                            personalInfoCommand.ExecuteNonQuery();
                        }

                        using (SqlCommand userInfoCommand = new SqlCommand(userInfoQuery, connection, transaction))
                        {
                            userInfoCommand.Parameters.AddWithValue("@ProfileID", user.ProfileID);
                            userInfoCommand.Parameters.AddWithValue("@TimeZoneID", user.TimeZoneID);
                            userInfoCommand.Parameters.AddWithValue("@Currency", user.Currency);
                            userInfoCommand.Parameters.AddWithValue("@UserSince", DateTimeOffset.UtcNow);

                            userInfoCommand.ExecuteNonQuery();
                        }

                            transaction.Commit(); // If all commands succeed, commit the transaction
                        MessageBox.Show("Profile created successfully.");
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // If any command fails, roll back the entire transaction
                    MessageBox.Show("Error creating profile: " + ex.Message);
                    return false;
                }
            }
        }

        public User GetUserInfo(User userInfo, Guid profileID)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryUserInfo = "SELECT L.ProfileID, L.PasswordHash, L.Role, L.Email, L.CountryCode, L.Phone, L.ProfileStatus, " +
                           "P.ProfileImage, P.FirstName, P.LastName, P.DOB, P.Gender, P.Country, P.GovtIDType, P.GovtID, P.AddressID, " +
                           "A.Country AS AddressCountry, A.City, A.Area, A.ZIP, A.Landmark, " +
                           "U.TimeZoneID, U.Currency, U.UserSince " +
                           "FROM Login L " +
                           "JOIN PersonalInfo P ON L.ProfileID = P.ProfileID " +
                           "JOIN Address A ON P.AddressID = A.AddressID " +
                           "JOIN UserInfo U ON L.ProfileID = U.ProfileID " +
                           "WHERE L.ProfileID = @ProfileID";

                using (SqlCommand userInfoCommand = new SqlCommand(queryUserInfo, connection))
                {
                    userInfoCommand.Parameters.AddWithValue("@ProfileID", profileID);

                    using (SqlDataReader reader = userInfoCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userInfo.ProfileID = (Guid)reader["ProfileID"];
                            userInfo.PasswordHash = reader["PasswordHash"].ToString();
                            userInfo.Role = reader["Role"].ToString();
                            userInfo.Email = reader["Email"].ToString();
                            userInfo.CountryCode = reader["CountryCode"].ToString();
                            userInfo.Phone = reader["Phone"].ToString();
                            userInfo.ProfileStatus = reader["ProfileStatus"].ToString();
                            byte[] ImageBytes = (byte[])reader["ProfileImage"];
                            userInfo.ProfilePicture = ConvertByteArrayToImage(ImageBytes);
                            userInfo.FirstName = reader["FirstName"].ToString();
                            userInfo.LastName = reader["LastName"].ToString();
                            userInfo.DOB = (DateTime)reader["DOB"];
                            userInfo.Gender = reader["Gender"].ToString();
                            userInfo.address.Country = reader["Country"].ToString();
                            userInfo.GovtIDType = reader["GovtIDType"].ToString();
                            userInfo.GovtID = reader["GovtID"].ToString();
                            userInfo.address.AddressID = (Guid)reader["AddressID"];
                            userInfo.address.Country = reader["AddressCountry"].ToString();
                            userInfo.address.City = reader["City"].ToString();
                            userInfo.address.Area = reader["Area"].ToString();
                            userInfo.address.Zip = reader["ZIP"].ToString();
                            userInfo.address.Landmark = reader["Landmark"].ToString();
                            userInfo.TimeZoneID = reader["TimeZoneID"].ToString();
                            userInfo.Currency = reader["Currency"].ToString();
                            userInfo.UserSince = (DateTimeOffset)reader["UserSince"];
                        }
                    }
                }


                return userInfo;
            }
        }


        private Image ConvertByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }


    }

}