using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dropify
{
    public partial class UserUI : BaseForm
    {
        public User user = new User();
        
        private string timeZoneID;
        TimeZoneInfo timeZoneInfo;
        DateTime timeZoneDateTime;

        public UserUI(Guid profileID)
        {
            InitializeComponent();
            InitializeTitlebar();

            user.GetUserInfo(user, profileID);
            lblFirstName.Text = user.FirstName;
            lblLastName.Text= user.LastName;
            btnProfile.BackgroundImage = user.ProfilePicture;
            btnProfile.BackgroundImageLayout = ImageLayout.Zoom;
            lblCurrency.Text = user.Currency;
            timeZoneID = user.TimeZoneID;
            timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZoneID);
            InitializeTimezoneTimer();


        }


        private void InitializeTitlebar()
        {
            base.TitlebarColorInt = 5119488;
            base.BorderColorInt = 5119488;
            base.WindowCorner = 3;
            
        }
        private void InitializeTimezoneTimer()
        {
            tTimezoneTime.Start();
        }

        private void tTimezoneTime_Tick(object sender, EventArgs e)
        {
            timeZoneDateTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);
            lblTimezoneTime.Text = timeZoneDateTime.ToString("hh:mm:ss tt");
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
            SecurityLog.Add(user.ProfileID, "Logout");
            SigninUI signinUI = new SigninUI();
            signinUI.Show();
            this.Hide();
        }

        private void btnParcel_Click(object sender, EventArgs e)
        {
            DeliveryUI parcelUI = new DeliveryUI(user, "Parcel");
            parcelUI.Show();
            this.Hide();
        }

        private void btnCourier_Click(object sender, EventArgs e)
        {
            DeliveryUI courierUI = new DeliveryUI(user, "Courier");
            courierUI.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            cbxAccount.DroppedDown = true;
        }

        private void cbxAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxAccount.SelectedIndex == 1)
            {
                Logout();
            }else if(cbxAccount.SelectedIndex == 0)
            {
                UserSettingsUI userSettingsUI = new UserSettingsUI(user.ProfileID);
                userSettingsUI.Show();
                this.Hide();

            }
            
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryUI historyUI = new HistoryUI(user.ProfileID);
            historyUI.Show();
            this.Hide();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            TrackDeliveryUI trackDeliveryUI = new TrackDeliveryUI(user.ProfileID);
            trackDeliveryUI.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteUserUI deleteUserUI = new DeleteUserUI(user);
            deleteUserUI.Show();
        }
    }
}
