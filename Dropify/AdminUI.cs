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
    public partial class AdminUI : BaseForm
    {
        public User admin = new User();
        private string connectionString = Properties.Settings.Default.ConnectionString;
        public AdminUI(Guid profileID)
        {
            InitializeComponent();
            admin.GetUserInfo(admin, profileID);
            InitializeTitlebar();
            tTimeZoneTimer.Start();
            UpdateDashboard();
        }

        private void UpdateDashboard()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                int loginCount = GetLoginEventCount(connection);
                int transactionCount = GetTransactionCount(connection);
                int notActivatedCount = GetNotActivatedCount(connection);

                lblLoginCount.Text = loginCount.ToString();
                lblTransactionCount.Text = transactionCount.ToString();
                lblNACcount.Text = notActivatedCount.ToString();
            }
        }

        static int GetLoginEventCount(SqlConnection connection)
        {
            int loginCount = 0;

            string query = "SELECT COUNT(*) FROM LoginInfo WHERE [Event] = 'Login'";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                loginCount = (int)command.ExecuteScalar();
            }

            return loginCount;
        }

        static int GetTransactionCount(SqlConnection connection)
        {
            int transactionCount = 0;

            string query = "SELECT COUNT(*) FROM TransactionInfo";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                transactionCount = (int)command.ExecuteScalar();
            }

            return transactionCount;
        }

        static int GetNotActivatedCount(SqlConnection connection)
        {
            int notActivatedCount = 0;

            string query = "SELECT COUNT(*) FROM Login WHERE ProfileStatus = 'Not Activated'";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                notActivatedCount = (int)command.ExecuteScalar();
            }

            return notActivatedCount;
        }

        private void InitializeTitlebar()
        {
            base.TitlebarColorInt = 0;
            base.BorderColorInt = 0;
            base.WindowCorner = 3;
            lblFirstName.Text = admin.FirstName;
            lblLastName.Text = admin.LastName;
            btnProfile.BackgroundImage = admin.ProfilePicture;
            btnProfile.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void tTimeZoneTimer_Tick(object sender, EventArgs e)
        {
            DateTime currentUserTime = TimeZoneInfoProvider.GetCityTime(admin.address.City);
            lblTimezoneTime.Text = currentUserTime.ToString("hh:mm:ss tt");
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            AdminInformationViewerUI viewer = new AdminInformationViewerUI(admin.ProfileID, "Security Log");
            viewer.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminInformationViewerUI viewer = new AdminInformationViewerUI(admin.ProfileID, "User Information");
            viewer.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminInformationViewerUI viewer = new AdminInformationViewerUI(admin.ProfileID, "Cost Management");
            viewer.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You will be logged out and taken to the home screen. Do you want to log out now?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                Logout();
            }

        }

        private void Logout()
        {
            SecurityLog.Add(admin.ProfileID, "Logout");
            SigninUI signinUI = new SigninUI();
            signinUI.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            cbxAccount.DroppedDown = true;
        }

        private void cbxAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAccount.SelectedIndex == 1)
            {

                SecurityLog.Add(admin.ProfileID, "Logout");
                SigninUI signinUI = new SigninUI();
                signinUI.Show();
                this.Hide();

            }else if (cbxAccount.SelectedIndex == 0)
            {
                AdminInformationViewerUI viewer = new AdminInformationViewerUI(admin.ProfileID, "System Settings");
                viewer.Show();
                this.Hide();
            }
        }
    }
}
