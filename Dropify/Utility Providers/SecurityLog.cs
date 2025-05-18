using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dropify
{
    public class SecurityLog
    {
        private static string connectionString = Properties.Settings.Default.ConnectionString;

        public static void Add(Guid profileID, string eventName)
        {
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string securityLog = "INSERT INTO LoginInfo (ProfileID, Event, Time, Device) VALUES (@ProfileID, @Event, @Time, @Device)";


                    using (SqlCommand command = new SqlCommand(securityLog, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@ProfileID", profileID);
                        command.Parameters.AddWithValue("@Event", eventName);
                        command.Parameters.AddWithValue("@Time", DateTimeOffset.UtcNow);
                        command.Parameters.AddWithValue("@Device", Environment.MachineName);

                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    


                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Security log insertion failed." , ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
