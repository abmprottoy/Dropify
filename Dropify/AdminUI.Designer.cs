
namespace Dropify
{
    partial class AdminUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUI));
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cbxAccount = new System.Windows.Forms.ComboBox();
            this.btnProfile = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTimezoneTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAdmin = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCopyright = new System.Windows.Forms.ToolStripStatusLabel();
            this.tTimeZoneTimer = new System.Windows.Forms.Timer(this.components);
            this.lblLoginCount = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblTransactionCount = new System.Windows.Forms.Label();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.lblNACcount = new System.Windows.Forms.Label();
            this.lblNAC = new System.Windows.Forms.Label();
            this.btnSecurity = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // cbxAccount
            // 
            this.cbxAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAccount.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.cbxAccount.FormattingEnabled = true;
            this.cbxAccount.Items.AddRange(new object[] {
            "Settings",
            "Logout"});
            this.cbxAccount.Location = new System.Drawing.Point(1092, 62);
            this.cbxAccount.Name = "cbxAccount";
            this.cbxAccount.Size = new System.Drawing.Size(70, 28);
            this.cbxAccount.TabIndex = 1;
            this.cbxAccount.SelectedIndexChanged += new System.EventHandler(this.cbxAccount_SelectedIndexChanged);
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
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Black;
            this.pnlTitle.Controls.Add(this.lblLastName);
            this.pnlTitle.Controls.Add(this.lblFirstName);
            this.pnlTitle.Controls.Add(this.lbl);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.btnBack);
            this.pnlTitle.Controls.Add(this.btnProfile);
            this.pnlTitle.Controls.Add(this.cbxAccount);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1174, 110);
            this.pnlTitle.TabIndex = 10;
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
            this.lblTitle.Size = new System.Drawing.Size(157, 65);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "admin";
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
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Black;
            this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTimezoneTime,
            this.lblAdmin,
            this.lblCopyright});
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1174, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 11;
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
            // lblAdmin
            // 
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(93, 19);
            this.lblAdmin.Text = "System Account";
            // 
            // lblCopyright
            // 
            this.lblCopyright.ForeColor = System.Drawing.Color.White;
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(986, 19);
            this.lblCopyright.Spring = true;
            this.lblCopyright.Text = "© 2023 Dropify Inc.";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tTimeZoneTimer
            // 
            this.tTimeZoneTimer.Interval = 1000;
            this.tTimeZoneTimer.Tick += new System.EventHandler(this.tTimeZoneTimer_Tick);
            // 
            // lblLoginCount
            // 
            this.lblLoginCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblLoginCount.AutoSize = true;
            this.lblLoginCount.Font = new System.Drawing.Font("Segoe UI Semilight", 42F);
            this.lblLoginCount.Location = new System.Drawing.Point(12, 204);
            this.lblLoginCount.Name = "lblLoginCount";
            this.lblLoginCount.Size = new System.Drawing.Size(174, 74);
            this.lblLoginCount.TabIndex = 12;
            this.lblLoginCount.Text = "12345";
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.lblLogin.Location = new System.Drawing.Point(26, 278);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(86, 37);
            this.lblLogin.TabIndex = 13;
            this.lblLogin.Text = "logins";
            // 
            // lblTransactionCount
            // 
            this.lblTransactionCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTransactionCount.AutoSize = true;
            this.lblTransactionCount.Font = new System.Drawing.Font("Segoe UI Semilight", 42F);
            this.lblTransactionCount.Location = new System.Drawing.Point(258, 204);
            this.lblTransactionCount.Name = "lblTransactionCount";
            this.lblTransactionCount.Size = new System.Drawing.Size(174, 74);
            this.lblTransactionCount.TabIndex = 12;
            this.lblTransactionCount.Text = "12345";
            // 
            // lblTransaction
            // 
            this.lblTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.lblTransaction.Location = new System.Drawing.Point(272, 278);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(157, 37);
            this.lblTransaction.TabIndex = 13;
            this.lblTransaction.Text = "transactions";
            // 
            // lblNACcount
            // 
            this.lblNACcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNACcount.AutoSize = true;
            this.lblNACcount.Font = new System.Drawing.Font("Segoe UI Semilight", 42F);
            this.lblNACcount.Location = new System.Drawing.Point(535, 204);
            this.lblNACcount.Name = "lblNACcount";
            this.lblNACcount.Size = new System.Drawing.Size(174, 74);
            this.lblNACcount.TabIndex = 12;
            this.lblNACcount.Text = "12345";
            // 
            // lblNAC
            // 
            this.lblNAC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNAC.AutoSize = true;
            this.lblNAC.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.lblNAC.Location = new System.Drawing.Point(549, 278);
            this.lblNAC.Name = "lblNAC";
            this.lblNAC.Size = new System.Drawing.Size(243, 37);
            this.lblNAC.TabIndex = 13;
            this.lblNAC.Text = "non activated users";
            // 
            // btnSecurity
            // 
            this.btnSecurity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSecurity.BackColor = System.Drawing.Color.Black;
            this.btnSecurity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnSecurity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecurity.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnSecurity.ForeColor = System.Drawing.Color.White;
            this.btnSecurity.Location = new System.Drawing.Point(937, 167);
            this.btnSecurity.Name = "btnSecurity";
            this.btnSecurity.Size = new System.Drawing.Size(225, 47);
            this.btnSecurity.TabIndex = 14;
            this.btnSecurity.Text = "Security Log";
            this.btnSecurity.UseVisualStyleBackColor = false;
            this.btnSecurity.Click += new System.EventHandler(this.btnSecurity_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(937, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 47);
            this.button2.TabIndex = 14;
            this.button2.Text = "User Information";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(937, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 47);
            this.button3.TabIndex = 14;
            this.button3.Text = "Cost Management";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 496);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSecurity);
            this.Controls.Add(this.lblNAC);
            this.Controls.Add(this.lblTransaction);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblNACcount);
            this.Controls.Add(this.lblTransactionCount);
            this.Controls.Add(this.lblLoginCount);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dropify - Admin";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripStatusLabel lblAdmin;
        private System.Windows.Forms.ToolStripStatusLabel lblCopyright;
        private System.Windows.Forms.Timer tTimeZoneTimer;
        private System.Windows.Forms.Label lblLoginCount;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblTransactionCount;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.Label lblNACcount;
        private System.Windows.Forms.Label lblNAC;
        private System.Windows.Forms.Button btnSecurity;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}