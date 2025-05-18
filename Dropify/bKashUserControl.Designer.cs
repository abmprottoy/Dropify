
namespace Dropify
{
    partial class bKashUserControl
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
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.mtbxPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblOTP = new System.Windows.Forms.Label();
            this.mtbxOTP = new System.Windows.Forms.MaskedTextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.tbxPin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI Semilight", 28F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(29)))), ((int)(((byte)(119)))));
            this.lblSubtitle.Location = new System.Drawing.Point(5, 34);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(291, 51);
            this.lblSubtitle.TabIndex = 8;
            this.lblSubtitle.Text = "Amount payable";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Segoe UI Semilight", 28F);
            this.lblCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(29)))), ((int)(((byte)(119)))));
            this.lblCurrency.Location = new System.Drawing.Point(5, 115);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(87, 51);
            this.lblCurrency.TabIndex = 8;
            this.lblCurrency.Text = "BDT";
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAmount.Font = new System.Drawing.Font("JetBrains Mono", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(29)))), ((int)(((byte)(119)))));
            this.lblAmount.Location = new System.Drawing.Point(120, 118);
            this.lblAmount.MaximumSize = new System.Drawing.Size(335, 38);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(176, 38);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "first name";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblPhone.ForeColor = System.Drawing.Color.Gray;
            this.lblPhone.Location = new System.Drawing.Point(550, 34);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(233, 21);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Enter your bKash Phone Number";
            // 
            // mtbxPhone
            // 
            this.mtbxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbxPhone.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.mtbxPhone.Location = new System.Drawing.Point(554, 71);
            this.mtbxPhone.Mask = "+8800000000000";
            this.mtbxPhone.Name = "mtbxPhone";
            this.mtbxPhone.PromptChar = ' ';
            this.mtbxPhone.Size = new System.Drawing.Size(229, 27);
            this.mtbxPhone.TabIndex = 14;
            // 
            // lblOTP
            // 
            this.lblOTP.AutoSize = true;
            this.lblOTP.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblOTP.ForeColor = System.Drawing.Color.Gray;
            this.lblOTP.Location = new System.Drawing.Point(550, 122);
            this.lblOTP.Name = "lblOTP";
            this.lblOTP.Size = new System.Drawing.Size(236, 21);
            this.lblOTP.TabIndex = 13;
            this.lblOTP.Text = "Enter the OTP sent to your phone";
            // 
            // mtbxOTP
            // 
            this.mtbxOTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbxOTP.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.mtbxOTP.Location = new System.Drawing.Point(554, 163);
            this.mtbxOTP.Mask = "000000";
            this.mtbxOTP.Name = "mtbxOTP";
            this.mtbxOTP.PromptChar = ' ';
            this.mtbxOTP.Size = new System.Drawing.Size(229, 27);
            this.mtbxOTP.TabIndex = 14;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblPin.ForeColor = System.Drawing.Color.Gray;
            this.lblPin.Location = new System.Drawing.Point(550, 220);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(154, 21);
            this.lblPin.TabIndex = 13;
            this.lblPin.Text = "Enter your bKash PIN";
            // 
            // tbxPin
            // 
            this.tbxPin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPin.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.tbxPin.Location = new System.Drawing.Point(554, 262);
            this.tbxPin.Name = "tbxPin";
            this.tbxPin.PasswordChar = '●';
            this.tbxPin.Size = new System.Drawing.Size(229, 27);
            this.tbxPin.TabIndex = 15;
            // 
            // bKashUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbxPin);
            this.Controls.Add(this.mtbxOTP);
            this.Controls.Add(this.mtbxPhone);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblOTP);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblSubtitle);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "bKashUserControl";
            this.Size = new System.Drawing.Size(820, 293);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.MaskedTextBox mtbxPhone;
        private System.Windows.Forms.Label lblOTP;
        private System.Windows.Forms.MaskedTextBox mtbxOTP;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox tbxPin;
    }
}
