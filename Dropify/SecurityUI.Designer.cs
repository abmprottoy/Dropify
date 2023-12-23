
namespace Dropify
{
    partial class SecurityUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecurityUI));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblSecurity = new System.Windows.Forms.Label();
            this.cbxSecurityQues = new System.Windows.Forms.ComboBox();
            this.tbxSecurityAns = new System.Windows.Forms.TextBox();
            this.lblSecurityAns = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.tbxOTP = new System.Windows.Forms.TextBox();
            this.lblOTP = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(29)))));
            this.pnlTitle.Controls.Add(this.lbl);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.btnBack);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(954, 110);
            this.pnlTitle.TabIndex = 1;
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
            this.lblTitle.Size = new System.Drawing.Size(185, 65);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "security";
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
            // lblSubtitle
            // 
            this.lblSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(29)))));
            this.lblSubtitle.Location = new System.Drawing.Point(115, 137);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(208, 37);
            this.lblSubtitle.TabIndex = 7;
            this.lblSubtitle.Text = "One more step...";
            // 
            // lblSecurity
            // 
            this.lblSecurity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecurity.AutoSize = true;
            this.lblSecurity.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblSecurity.ForeColor = System.Drawing.Color.Gray;
            this.lblSecurity.Location = new System.Drawing.Point(118, 217);
            this.lblSecurity.Name = "lblSecurity";
            this.lblSecurity.Size = new System.Drawing.Size(130, 21);
            this.lblSecurity.TabIndex = 18;
            this.lblSecurity.Text = "Security Question";
            // 
            // cbxSecurityQues
            // 
            this.cbxSecurityQues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSecurityQues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSecurityQues.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.cbxSecurityQues.FormattingEnabled = true;
            this.cbxSecurityQues.Items.AddRange(new object[] {
            "What is your favorite color?",
            "What was your childhood pet\'s name?",
            "Who is your favorite singer?",
            "Who is your favorite teacher?"});
            this.cbxSecurityQues.Location = new System.Drawing.Point(311, 215);
            this.cbxSecurityQues.Name = "cbxSecurityQues";
            this.cbxSecurityQues.Size = new System.Drawing.Size(281, 28);
            this.cbxSecurityQues.Sorted = true;
            this.cbxSecurityQues.TabIndex = 1;
            // 
            // tbxSecurityAns
            // 
            this.tbxSecurityAns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSecurityAns.BackColor = System.Drawing.Color.White;
            this.tbxSecurityAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSecurityAns.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.tbxSecurityAns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tbxSecurityAns.Location = new System.Drawing.Point(311, 288);
            this.tbxSecurityAns.MaxLength = 128;
            this.tbxSecurityAns.Name = "tbxSecurityAns";
            this.tbxSecurityAns.Size = new System.Drawing.Size(281, 27);
            this.tbxSecurityAns.TabIndex = 2;
            this.tbxSecurityAns.TextChanged += new System.EventHandler(this.tbxSecurityAns_TextChanged);
            // 
            // lblSecurityAns
            // 
            this.lblSecurityAns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecurityAns.AutoSize = true;
            this.lblSecurityAns.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblSecurityAns.ForeColor = System.Drawing.Color.Gray;
            this.lblSecurityAns.Location = new System.Drawing.Point(118, 289);
            this.lblSecurityAns.Name = "lblSecurityAns";
            this.lblSecurityAns.Size = new System.Drawing.Size(117, 21);
            this.lblSecurityAns.TabIndex = 19;
            this.lblSecurityAns.Text = "Security Answer";
            // 
            // btnVerify
            // 
            this.btnVerify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnVerify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnVerify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(29)))));
            this.btnVerify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.Black;
            this.btnVerify.Location = new System.Drawing.Point(610, 353);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 27);
            this.btnVerify.TabIndex = 4;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // tbxOTP
            // 
            this.tbxOTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxOTP.BackColor = System.Drawing.Color.White;
            this.tbxOTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxOTP.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.tbxOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tbxOTP.Location = new System.Drawing.Point(311, 353);
            this.tbxOTP.MaxLength = 128;
            this.tbxOTP.Name = "tbxOTP";
            this.tbxOTP.Size = new System.Drawing.Size(281, 27);
            this.tbxOTP.TabIndex = 3;
            // 
            // lblOTP
            // 
            this.lblOTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOTP.AutoSize = true;
            this.lblOTP.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblOTP.ForeColor = System.Drawing.Color.Gray;
            this.lblOTP.Location = new System.Drawing.Point(118, 359);
            this.lblOTP.Name = "lblOTP";
            this.lblOTP.Size = new System.Drawing.Size(38, 21);
            this.lblOTP.TabIndex = 22;
            this.lblOTP.Text = "OTP";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(29)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(311, 433);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(735, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(731, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 42);
            this.label2.TabIndex = 26;
            this.label2.Text = "Please scan this code with\r\nyour Authenticator app.";
            // 
            // SecurityUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 506);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxOTP);
            this.Controls.Add(this.lblOTP);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.tbxSecurityAns);
            this.Controls.Add(this.lblSecurityAns);
            this.Controls.Add(this.lblSecurity);
            this.Controls.Add(this.cbxSecurityQues);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.pnlTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SecurityUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecurityUI";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblSecurity;
        private System.Windows.Forms.ComboBox cbxSecurityQues;
        private System.Windows.Forms.TextBox tbxSecurityAns;
        private System.Windows.Forms.Label lblSecurityAns;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox tbxOTP;
        private System.Windows.Forms.Label lblOTP;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}