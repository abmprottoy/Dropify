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
    public partial class SystemMaintenenceUserControl : UserControl
    {
        public string connectionString = Properties.Settings.Default.ConnectionString;
        private string currentStatus;
        private string maintenenceString = "Disconnected for server maintenece";
        private string onlineString = "Connected";
        public SystemMaintenenceUserControl()
        {
            InitializeComponent();
            currentStatus = ReadServerStatusProperty();
            lblServerStatus.Text = currentStatus;

            if(currentStatus == onlineString)
            {
                btnMaintenence.Enabled = true;
                btnBringOnline.Enabled = false;
            }else if (currentStatus == maintenenceString)
            {
                btnBringOnline.Enabled = true;
                btnMaintenence.Enabled = false;
            }
        }

        private void btnMaintenence_Click(object sender, EventArgs e)
        {
            UpdateServerStatusProperty(maintenenceString);
            btnMaintenence.Enabled = false;
            btnBringOnline.Enabled = true;
        }

        private void btnBringOnline_Click(object sender, EventArgs e)
        {
            UpdateServerStatusProperty(onlineString);
            btnBringOnline.Enabled = false;
            btnMaintenence.Enabled = true;
        }

        private void UpdateServerStatusProperty(string properties)
        {
            try
            {

                string updateQuery = "UPDATE System SET Properties = @Properties WHERE Item = 'ServerStatus'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {

                        command.Parameters.AddWithValue("@Properties", properties);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            currentStatus = ReadServerStatusProperty();
                            lblServerStatus.Text = currentStatus;
                        }
                        else
                        {
                            MessageBox.Show("Update failed. No matching rows found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating ServerStatus property: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private string ReadServerStatusProperty()
        {
            string currentServerStatus = string.Empty;

            try
            {

                string selectQuery = "SELECT Properties FROM System WHERE Item = 'ServerStatus'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        object queryResult = command.ExecuteScalar();

                        if (queryResult != null)
                        {
                            currentServerStatus = queryResult.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Read failed. No matching rows found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading ServerStatus property: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return currentServerStatus;
        }
    }
}
