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
    public partial class SystemInformationUserControl : UserControl
    {
        public string connectionString = Properties.Settings.Default.ConnectionString;
        private DateTime serverStartTime;
        public SystemInformationUserControl()
        {
            InitializeComponent();

            // Load system information when the UserControl is initialized
            LoadSystemInformation();
            uptimeTimer.Start();
        }

        private void LoadSystemInformation()
        {
            try
            {
                // Get SQL Server Version
                string versionResult = ExecuteScalarQuery("SELECT @@VERSION");
                lblDeviceName.Text = versionResult;

                // Get SQL Server Uptime
                string uptimeResult = ExecuteScalarQuery("USE master; SELECT login_time as [SQL Server Instance Uptime] FROM sys.sysprocesses WHERE spid = 1");
                serverStartTime = DateTime.Parse(uptimeResult);
                UpdateUptimeLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Log or handle the exception as needed
            }
        }


        private void UpdateUptimeLabel()
        {
            // Calculate the uptime difference between current time and server start time
            TimeSpan uptime = DateTime.Now - serverStartTime;
            lblUptime.Text = $"Server Uptime: {FormatTimeSpan(uptime)}";
        }
        private string FormatTimeSpan(TimeSpan timeSpan)
        {
            return $"{timeSpan.Days} days, {timeSpan.Hours} hours, {timeSpan.Minutes} minutes, {timeSpan.Seconds} seconds";
        }

        private string ExecuteScalarQuery(string query)
        {
            string result = string.Empty;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object queryResult = command.ExecuteScalar();

                    if (queryResult != null)
                    {
                        result = queryResult.ToString();
                    }
                    else
                    {
                        result = "No result";
                    }
                }
            }

            return result;
        }

        private void uptimeTimer_Tick(object sender, EventArgs e)
        {
            UpdateUptimeLabel();
        }
    }
}
