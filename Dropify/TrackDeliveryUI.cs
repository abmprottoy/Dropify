using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dropify
{
    public partial class TrackDeliveryUI : BaseForm
    {
        public User user = new User();
        public Delivery delivery = new Delivery();

        public TrackDeliveryUI(Guid profileID)
        {
            InitializeComponent();
            user.GetUserInfo(user, profileID);
            InitializeTitlebar();
            tTimeZoneTimer.Start();
            lblDetails.Hide();
        }

        private void InitializeTitlebar()
        {
            base.TitlebarColorInt = 5119488;
            base.BorderColorInt = 5119488;
            base.WindowCorner = 3;
            lblFirstName.Text = user.FirstName;
            lblLastName.Text = user.LastName;
            btnProfile.BackgroundImage = user.ProfilePicture;
            btnProfile.BackgroundImageLayout = ImageLayout.Zoom;
            lblCurrency.Text = user.Currency;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserUI userUI = new UserUI(user.ProfileID);
            userUI.Show();
            this.Hide();
        }

        private void tTimeZoneTimer_Tick(object sender, EventArgs e)
        {
            DateTime currentUserTime = TimeZoneInfoProvider.GetCityTime(user.address.City);
            lblTimezoneTime.Text = currentUserTime.ToString("hh:mm:ss tt");
        }

        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
           
            if( string.IsNullOrWhiteSpace(tbxPackageID.Text))
            {
                MessageBox.Show("Enter a package ID");
            }
            else
            {
                

                string deliveryStatus = delivery.GetDeliveryStatus(Guid.Parse(tbxPackageID.Text));
                lblDetails.Text = deliveryStatus;
                lblDetails.Show();
            }
 
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            cbxAccount.DroppedDown = true;
        }

        private void cbxAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAccount.SelectedIndex == 0)
            {

                SecurityLog.Add(user.ProfileID, "Logout");
                SigninUI signinUI = new SigninUI();
                signinUI.Show();
                this.Hide();

            }
        }
    }
}
