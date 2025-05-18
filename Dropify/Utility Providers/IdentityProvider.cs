using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dropify
{
    public class IdentityProvider
    {
        public static string connectionString = Properties.Settings.Default.ConnectionString;

        //Employee ID format: P for ParcelDelivery, C for Courier, M for Manager, a dash followed by year last two digit a 4 digit number starts from 1000 for each type of employee
        //Example: P-171000, C-171000, M-171000 and ends with dash and 2 digit index for the city they are based on. Example: P-171000-01, C-171000-01, M-171000-01
        public static string GenerateEmployeeID(string employeeType, string city)
        {
            string employeeID = string.Empty;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Properties FROM System WHERE Item = 'EmployeeCount'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            int count = Convert.ToInt32(result);

                            count++;

                            query = "UPDATE System SET Properties = @count WHERE Item = 'EmployeeCount'";

                            using (SqlCommand updateCommand = new SqlCommand(query, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@count", count);

                                updateCommand.ExecuteNonQuery();
                            }

                            employeeID = employeeType + "-" + DateTime.Now.Year.ToString().Substring(2) + count.ToString("D4") + "-" + city;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return employeeID;
        }

        private int GetEmployeeCount()
        {
            int count = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Properties FROM System WHERE Item = 'EmployeeCount'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();

                        if(result != null && result != DBNull.Value)
                        {
                            count = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return count;
        }
    }
}
