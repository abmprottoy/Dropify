
namespace Dropify
{
    partial class UserSettingsUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettingsUI));
            this.tTimeZoneTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTimezoneTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurrency = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCopyright = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbxAccount = new System.Windows.Forms.ComboBox();
            this.btnMaintenence = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSecurity = new System.Windows.Forms.Panel();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.lblChangePass = new System.Windows.Forms.Label();
            this.lbxAccountSidebar = new ModernListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlSecurity.SuspendLayout();
            this.SuspendLayout();
            // 
            // tTimeZoneTimer
            // 
            this.tTimeZoneTimer.Interval = 1000;
            this.tTimeZoneTimer.Tick += new System.EventHandler(this.tTimeZoneTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlSettings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 362);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.panel2.Controls.Add(this.lbxAccountSidebar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 362);
            this.panel2.TabIndex = 2;
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackColor = System.Drawing.Color.White;
            this.pnlSettings.Controls.Add(this.pnlSecurity);
            this.pnlSettings.Controls.Add(this.label1);
            this.pnlSettings.Controls.Add(this.btnMaintenence);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettings.Location = new System.Drawing.Point(0, 0);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(1174, 362);
            this.pnlSettings.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTimezoneTime,
            this.lblCurrency,
            this.lblCopyright});
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1174, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTimezoneTime
            // 
            this.lblTimezoneTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblTimezoneTime.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblTimezoneTime.ForeColor = System.Drawing.Color.White;
            this.lblTimezoneTime.Name = "lblTimezoneTime";
            this.lblTimezoneTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTimezoneTime.Size = new System.Drawing.Size(80, 19);
            this.lblTimezoneTime.Text = "Current Time";
            this.lblTimezoneTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrency
            // 
            this.lblCurrency.ForeColor = System.Drawing.Color.White;
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(55, 19);
            this.lblCurrency.Text = "Currency";
            // 
            // lblCopyright
            // 
            this.lblCopyright.ForeColor = System.Drawing.Color.White;
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(1024, 19);
            this.lblCopyright.Spring = true;
            this.lblCopyright.Text = "© 2023 Dropify Inc.";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.pnlTitle.Controls.Add(this.btnProfile);
            this.pnlTitle.Controls.Add(this.lblLastName);
            this.pnlTitle.Controls.Add(this.lblFirstName);
            this.pnlTitle.Controls.Add(this.lbl);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.btnBack);
            this.pnlTitle.Controls.Add(this.cbxAccount);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1174, 110);
            this.pnlTitle.TabIndex = 9;
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfile.BackgroundImage = global::Dropify.Properties.Resources.Avatar_Default;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfile.Location = new System.Drawing.Point(1092, 20);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(70, 70);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.AutoEllipsis = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(993, 62);
            this.lblLastName.MaximumSize = new System.Drawing.Size(93, 28);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(93, 28);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "last name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Semilight", 21F);
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(813, 20);
            this.lblFirstName.MaximumSize = new System.Drawing.Size(335, 38);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(279, 38);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "first name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(119, 25);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(56, 15);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "DROPIFY";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 36F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(111, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(364, 65);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "account settings";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Symbol", 42F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(0, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 105);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbxAccount
            // 
            this.cbxAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAccount.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.cbxAccount.FormattingEnabled = true;
            this.cbxAccount.Items.AddRange(new object[] {
            "Logout"});
            this.cbxAccount.Location = new System.Drawing.Point(1092, 62);
            this.cbxAccount.Name = "cbxAccount";
            this.cbxAccount.Size = new System.Drawing.Size(70, 28);
            this.cbxAccount.TabIndex = 1;
            this.cbxAccount.SelectedIndexChanged += new System.EventHandler(this.cbxAccount_SelectedIndexChanged);
            // 
            // btnMaintenence
            // 
            this.btnMaintenence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnMaintenence.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnMaintenence.FlatAppearance.BorderSize = 2;
            this.btnMaintenence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMaintenence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaintenence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenence.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenence.ForeColor = System.Drawing.Color.White;
            this.btnMaintenence.Location = new System.Drawing.Point(256, 62);
            this.btnMaintenence.Name = "btnMaintenence";
            this.btnMaintenence.Size = new System.Drawing.Size(209, 31);
            this.btnMaintenence.TabIndex = 12;
            this.btnMaintenence.Text = "Delete Account";
            this.btnMaintenence.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaintenence.UseVisualStyleBackColor = false;
            this.btnMaintenence.Click += new System.EventHandler(this.btnMaintenence_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.label1.Location = new System.Drawing.Point(250, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Delete your account";
            // 
            // pnlSecurity
            // 
            this.pnlSecurity.Controls.Add(this.lblChangePass);
            this.pnlSecurity.Controls.Add(this.btnChangePass);
            this.pnlSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSecurity.Location = new System.Drawing.Point(0, 0);
            this.pnlSecurity.Name = "pnlSecurity";
            this.pnlSecurity.Size = new System.Drawing.Size(1174, 362);
            this.pnlSecurity.TabIndex = 14;
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
            // lbxAccountSidebar
            // 
            this.lbxAccountSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.lbxAccountSidebar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxAccountSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxAccountSidebar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbxAccountSidebar.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAccountSidebar.ForeColor = System.Drawing.Color.White;
            this.lbxAccountSidebar.FormattingEnabled = true;
            this.lbxAccountSidebar.HoverBackgroundColor = System.Drawing.Color.LightGray;
            this.lbxAccountSidebar.ItemHeight = 40;
            this.lbxAccountSidebar.Items.AddRange(new object[] {
            "Account Security",
            "Account Settings"});
            this.lbxAccountSidebar.ItemTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbxAccountSidebar.ItemTextColor = System.Drawing.Color.White;
            this.lbxAccountSidebar.Location = new System.Drawing.Point(0, 0);
            this.lbxAccountSidebar.Name = "lbxAccountSidebar";
            this.lbxAccountSidebar.SelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.lbxAccountSidebar.SelectedItemTextColor = System.Drawing.SystemColors.HighlightText;
            this.lbxAccountSidebar.Size = new System.Drawing.Size(236, 362);
            this.lbxAccountSidebar.TabIndex = 0;
            this.lbxAccountSidebar.TextPadding = new System.Windows.Forms.Padding(0);
            this.lbxAccountSidebar.SelectedIndexChanged += new System.EventHandler(this.lbxAccountSidebar_SelectedIndexChanged);
            // 
            // UserSettingsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserSettingsUI";
            this.Text = "Dropify -User Settings";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlSecurity.ResumeLayout(false);
            this.pnlSecurity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ComboBox cbxAccount;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTimezoneTime;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrency;
        private System.Windows.Forms.ToolStripStatusLabel lblCopyright;
        private System.Windows.Forms.Timer tTimeZoneTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ModernListBox lbxAccountSidebar;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Button btnMaintenence;
        private System.Windows.Forms.Panel pnlSecurity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Label lblChangePass;
    }
}