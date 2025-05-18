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
    
    public partial class UserSettingsUI : BaseForm
    {
        public User user = new User();
        PasswordChangeUserControl passwordChanger;
       

        public UserSettingsUI(Guid profileID)
        {
            InitializeComponent();
            user.GetUserInfo(user, profileID);
            InitializeTitlebar();
            tTimeZoneTimer.Start();
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

        private void tTimeZoneTimer_Tick(object sender, EventArgs e)
        {
            DateTime currentUserTime = TimeZoneInfoProvider.GetCityTime(user.address.City);
            lblTimezoneTime.Text = currentUserTime.ToString("hh:mm:ss tt");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserUI userUI = new UserUI(user.ProfileID);
            userUI.Show();
            this.Hide();
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

        private void lbxAccountSidebar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbxAccountSidebar.SelectedIndex == 0)
            {


                Button btnChangePass = new System.Windows.Forms.Button();
                Label lblChangePass = new System.Windows.Forms.Label();
                // 
                // lblChangePass
                // 
                this.lblChangePass.AutoSize = true;
                this.lblChangePass.BackColor = System.Drawing.Color.White;
                this.lblChangePass.Font = new System.Drawing.Font("Segoe UI Semilight", 18F);
                this.lblChangePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
                this.lblChangePass.Location = new System.Drawing.Point(252, 15);
                this.lblChangePass.Name = "lblChangePass";
                this.lblChangePass.Size = new System.Drawing.Size(253, 32);
                this.lblChangePass.TabIndex = 13;
                this.lblChangePass.Text = "Change your password";

                // 
                // btnChangePass
                // 
                this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(117)))), ((int)(((byte)(70)))));
                this.btnChangePass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(117)))), ((int)(((byte)(70)))));
                this.btnChangePass.FlatAppearance.BorderSize = 2;
                this.btnChangePass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
                this.btnChangePass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.btnChangePass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnChangePass.ForeColor = System.Drawing.Color.White;
                this.btnChangePass.Location = new System.Drawing.Point(256, 79);
                this.btnChangePass.Name = "btnChangePass";
                this.btnChangePass.Size = new System.Drawing.Size(209, 31);
                this.btnChangePass.TabIndex = 12;
                this.btnChangePass.Text = "change password";
                this.btnChangePass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                this.btnChangePass.UseVisualStyleBackColor = false;
                this.btnChangePass.Click += new System.EventHandler(this.btnBringOnline_Click);

                // 
                // pnlSecurity
                // 
                this.pnlSecurity.Controls.Add(lblChangePass);
                this.pnlSecurity.Controls.Add(btnChangePass);
                pnlSecurity.BackColor = Color.White;
                this.pnlSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
                this.pnlSecurity.Location = new System.Drawing.Point(150, 0);
                this.pnlSecurity.Name = "pnlSecurity";
                this.pnlSecurity.Size = new System.Drawing.Size(1174, 362);
                this.pnlSecurity.TabIndex = 14;

                panel1.Controls.Add(pnlSecurity);
                pnlSecurity.Dock = DockStyle.Right;

                pnlSecurity.Show();
                pnlSettings.Hide();
            }else if(lbxAccountSidebar.SelectedIndex == 1){
                pnlSecurity.Hide();
                pnlSettings.Show();
            }
        }

        private void btnBringOnline_Click(object sender, EventArgs e)
        {
            passwordChanger = new PasswordChangeUserControl(user.ProfileID);
            pnlSecurity.Controls.Clear();
            pnlSecurity.Controls.Add(passwordChanger);
            passwordChanger.Dock = DockStyle.Right;
        }

        private void btnMaintenence_Click(object sender, EventArgs e)
        {
            DeleteUserUI deleteUserUI = new DeleteUserUI(user);
            deleteUserUI.Show();
        }
    }
}
