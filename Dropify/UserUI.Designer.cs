﻿
namespace Dropify
{
    partial class UserUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUI));
            this.btnProfile = new System.Windows.Forms.Button();
            this.cbxAccount = new System.Windows.Forms.ComboBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTrack = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnCourier = new System.Windows.Forms.Button();
            this.btnParcel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTimezoneTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurrency = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCopyright = new System.Windows.Forms.ToolStripStatusLabel();
            this.tTimezoneTime = new System.Windows.Forms.Timer(this.components);
            this.pnlTitle.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
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
            this.pnlTitle.TabIndex = 2;
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
            this.lblTitle.Size = new System.Drawing.Size(115, 65);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "user";
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
            // btnTrack
            // 
            this.btnTrack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTrack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrack.Image = global::Dropify.Properties.Resources.TrackTile;
            this.btnTrack.Location = new System.Drawing.Point(877, 213);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(250, 141);
            this.btnTrack.TabIndex = 6;
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistory.Image = global::Dropify.Properties.Resources.CheckHistory;
            this.btnHistory.Location = new System.Drawing.Point(599, 213);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(250, 141);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnCourier
            // 
            this.btnCourier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCourier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCourier.Image = global::Dropify.Properties.Resources.CourierTile;
            this.btnCourier.Location = new System.Drawing.Point(322, 213);
            this.btnCourier.Name = "btnCourier";
            this.btnCourier.Size = new System.Drawing.Size(250, 141);
            this.btnCourier.TabIndex = 4;
            this.btnCourier.UseVisualStyleBackColor = true;
            this.btnCourier.Click += new System.EventHandler(this.btnCourier_Click);
            // 
            // btnParcel
            // 
            this.btnParcel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnParcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnParcel.Image = global::Dropify.Properties.Resources.ParcelTile;
            this.btnParcel.Location = new System.Drawing.Point(46, 213);
            this.btnParcel.Name = "btnParcel";
            this.btnParcel.Size = new System.Drawing.Size(250, 141);
            this.btnParcel.TabIndex = 3;
            this.btnParcel.UseVisualStyleBackColor = true;
            this.btnParcel.Click += new System.EventHandler(this.btnParcel_Click);
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
            this.statusStrip1.TabIndex = 7;
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
            // tTimezoneTime
            // 
            this.tTimezoneTime.Enabled = true;
            this.tTimezoneTime.Interval = 1000;
            this.tTimezoneTime.Tick += new System.EventHandler(this.tTimezoneTime_Tick);
            // 
            // UserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1174, 496);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnTrack);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnCourier);
            this.Controls.Add(this.btnParcel);
            this.Controls.Add(this.pnlTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dropify - User";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.ComboBox cbxAccount;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnParcel;
        private System.Windows.Forms.Button btnCourier;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTimezoneTime;
        private System.Windows.Forms.ToolStripStatusLabel lblCopyright;
        private System.Windows.Forms.Timer tTimezoneTime;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrency;
        private System.Windows.Forms.Label lblFirstName;
    }
}