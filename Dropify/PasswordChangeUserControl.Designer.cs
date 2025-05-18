
namespace Dropify
{
    partial class PasswordChangeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxOTP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOTP = new System.Windows.Forms.Label();
            this.btnOTPVerify = new System.Windows.Forms.Button();
            this.tbxSecurityAns = new System.Windows.Forms.TextBox();
            this.lblSecurityAns = new System.Windows.Forms.Label();
            this.lblSecurity = new System.Windows.Forms.Label();
            this.tbxSecurityQues = new System.Windows.Forms.TextBox();
            this.btnSecurityAnsVerify = new System.Windows.Forms.Button();
            this.ttPasswordValid = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(326, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 27);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Update Password";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPassword.BackColor = System.Drawing.Color.White;
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPassword.Enabled = false;
            this.tbxPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.tbxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tbxPassword.Location = new System.Drawing.Point(326, 190);
            this.tbxPassword.MaxLength = 128;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(281, 27);
            this.tbxPassword.TabIndex = 34;
            this.tbxPassword.TextChanged += new System.EventHandler(this.tbxPassword_TextChanged);
            // 
            // tbxOTP
            // 
            this.tbxOTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxOTP.BackColor = System.Drawing.Color.White;
            this.tbxOTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxOTP.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.tbxOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tbxOTP.Location = new System.Drawing.Point(326, 129);
            this.tbxOTP.MaxLength = 128;
            this.tbxOTP.Name = "tbxOTP";
            this.tbxOTP.Size = new System.Drawing.Size(281, 27);
            this.tbxOTP.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(133, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "New Password";
            // 
            // lblOTP
            // 
            this.lblOTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOTP.AutoSize = true;
            this.lblOTP.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblOTP.ForeColor = System.Drawing.Color.Gray;
            this.lblOTP.Location = new System.Drawing.Point(133, 135);
            this.lblOTP.Name = "lblOTP";
            this.lblOTP.Size = new System.Drawing.Size(38, 21);
            this.lblOTP.TabIndex = 42;
            this.lblOTP.Text = "OTP";
            // 
            // btnOTPVerify
            // 
            this.btnOTPVerify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOTPVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOTPVerify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOTPVerify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(29)))));
            this.btnOTPVerify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnOTPVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOTPVerify.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOTPVerify.ForeColor = System.Drawing.Color.Black;
            this.btnOTPVerify.Location = new System.Drawing.Point(625, 129);
            this.btnOTPVerify.Name = "btnOTPVerify";
            this.btnOTPVerify.Size = new System.Drawing.Size(75, 27);
            this.btnOTPVerify.TabIndex = 37;
            this.btnOTPVerify.Text = "Verify";
            this.btnOTPVerify.UseVisualStyleBackColor = false;
            this.btnOTPVerify.Click += new System.EventHandler(this.btnOTPVerify_Click);
            // 
            // tbxSecurityAns
            // 
            this.tbxSecurityAns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSecurityAns.BackColor = System.Drawing.Color.White;
            this.tbxSecurityAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSecurityAns.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.tbxSecurityAns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tbxSecurityAns.Location = new System.Drawing.Point(326, 74);
            this.tbxSecurityAns.MaxLength = 128;
            this.tbxSecurityAns.Name = "tbxSecurityAns";
            this.tbxSecurityAns.Size = new System.Drawing.Size(281, 27);
            this.tbxSecurityAns.TabIndex = 32;
            // 
            // lblSecurityAns
            // 
            this.lblSecurityAns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecurityAns.AutoSize = true;
            this.lblSecurityAns.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblSecurityAns.ForeColor = System.Drawing.Color.Gray;
            this.lblSecurityAns.Location = new System.Drawing.Point(133, 75);
            this.lblSecurityAns.Name = "lblSecurityAns";
            this.lblSecurityAns.Size = new System.Drawing.Size(117, 21);
            this.lblSecurityAns.TabIndex = 39;
            this.lblSecurityAns.Text = "Security Answer";
            // 
            // lblSecurity
            // 
            this.lblSecurity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecurity.AutoSize = true;
            this.lblSecurity.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblSecurity.ForeColor = System.Drawing.Color.Gray;
            this.lblSecurity.Location = new System.Drawing.Point(133, 21);
            this.lblSecurity.Name = "lblSecurity";
            this.lblSecurity.Size = new System.Drawing.Size(130, 21);
            this.lblSecurity.TabIndex = 38;
            this.lblSecurity.Text = "Security Question";
            // 
            // tbxSecurityQues
            // 
            this.tbxSecurityQues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSecurityQues.BackColor = System.Drawing.Color.White;
            this.tbxSecurityQues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSecurityQues.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.tbxSecurityQues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tbxSecurityQues.Location = new System.Drawing.Point(326, 20);
            this.tbxSecurityQues.MaxLength = 128;
            this.tbxSecurityQues.Name = "tbxSecurityQues";
            this.tbxSecurityQues.ReadOnly = true;
            this.tbxSecurityQues.Size = new System.Drawing.Size(281, 20);
            this.tbxSecurityQues.TabIndex = 32;
            // 
            // btnSecurityAnsVerify
            // 
            this.btnSecurityAnsVerify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSecurityAnsVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSecurityAnsVerify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSecurityAnsVerify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(29)))));
            this.btnSecurityAnsVerify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSecurityAnsVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecurityAnsVerify.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecurityAnsVerify.ForeColor = System.Drawing.Color.Black;
            this.btnSecurityAnsVerify.Location = new System.Drawing.Point(625, 74);
            this.btnSecurityAnsVerify.Name = "btnSecurityAnsVerify";
            this.btnSecurityAnsVerify.Size = new System.Drawing.Size(75, 27);
            this.btnSecurityAnsVerify.TabIndex = 37;
            this.btnSecurityAnsVerify.Text = "Verify";
            this.btnSecurityAnsVerify.UseVisualStyleBackColor = false;
            this.btnSecurityAnsVerify.Click += new System.EventHandler(this.btnSecurityAnsVerify_Click);
            // 
            // PasswordChangeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxOTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOTP);
            this.Controls.Add(this.btnSecurityAnsVerify);
            this.Controls.Add(this.btnOTPVerify);
            this.Controls.Add(this.tbxSecurityQues);
            this.Controls.Add(this.tbxSecurityAns);
            this.Controls.Add(this.lblSecurityAns);
            this.Controls.Add(this.lblSecurity);
            this.Name = "PasswordChangeUserControl";
            this.Size = new System.Drawing.Size(835, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxOTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOTP;
        private System.Windows.Forms.Button btnOTPVerify;
        private System.Windows.Forms.TextBox tbxSecurityAns;
        private System.Windows.Forms.Label lblSecurityAns;
        private System.Windows.Forms.Label lblSecurity;
        private System.Windows.Forms.TextBox tbxSecurityQues;
        private System.Windows.Forms.Button btnSecurityAnsVerify;
        private System.Windows.Forms.ToolTip ttPasswordValid;
    }
}
