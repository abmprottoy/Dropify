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
    public partial class AdminInformationViewerUI : BaseForm
    {
        public User admin = new User();
        SecurityLogUI securityLogUI;
        UserInformationUI userInformationUI;
        CostManagementUI costManagementUI;
        SystemInformationUI systemInformationUI;
        public AdminInformationViewerUI(Guid profileID, string layout)
        {
            InitializeComponent();
            admin.GetUserInfo(admin, profileID);
            InitializeTitlebar();
            tTimeZoneTimer.Start();

            lblTitle.Text = layout.ToLower();
            this.Text = "Dropify - " + layout; 

            securityLogUI = new SecurityLogUI();
            userInformationUI = new UserInformationUI();
            costManagementUI = new CostManagementUI();
            systemInformationUI = new SystemInformationUI();

            LayoutRouter(layout);
        }

        private void LayoutRouter(string layout)
        {
            switch (layout.ToLower())
            {
                case "security log":
                    pnlContent.Controls.Clear();
                    pnlContent.Controls.Add(securityLogUI);
                    securityLogUI.Dock = DockStyle.Fill;
                    break;


                case "user information":
                    pnlContent.Controls.Clear();
                    pnlContent.Controls.Add(userInformationUI);
                    userInformationUI.Dock = DockStyle.Fill;
                    break;

                case "cost management":
                    pnlContent.Controls.Clear();
                    pnlContent.Controls.Add(costManagementUI);
                    costManagementUI.Dock = DockStyle.Fill;
                    break;
                case "system settings":
                    pnlContent.Controls.Clear();
                    pnlContent.Controls.Add(systemInformationUI);
                    systemInformationUI.Dock = DockStyle.Fill;
                    break;
            }
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminUI adminUI = new AdminUI(admin.ProfileID);
            adminUI.Show();
            this.Hide();
        }

        private void cbxAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxAccount.SelectedIndex == 0)
            {
                
                    SecurityLog.Add(admin.ProfileID, "Logout");
                    SigninUI signinUI = new SigninUI();
                    signinUI.Show();
                    this.Hide();
                
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            cbxAccount.DroppedDown = true;
        }

    }
}
