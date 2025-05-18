
namespace Dropify
{
    partial class CardPaymentUserControl
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
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.mtbxMM = new System.Windows.Forms.MaskedTextBox();
            this.mtbxCard = new System.Windows.Forms.MaskedTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.mtbxYYYY = new System.Windows.Forms.MaskedTextBox();
            this.mtbxCCC = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Segoe UI Semilight", 28F);
            this.lblCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(29)))), ((int)(((byte)(119)))));
            this.lblCurrency.Location = new System.Drawing.Point(5, 109);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(93, 51);
            this.lblCurrency.TabIndex = 10;
            this.lblCurrency.Text = "USD";
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAmount.Font = new System.Drawing.Font("JetBrains Mono", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(29)))), ((int)(((byte)(119)))));
            this.lblAmount.Location = new System.Drawing.Point(120, 112);
            this.lblAmount.MaximumSize = new System.Drawing.Size(335, 38);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(176, 38);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "first name";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI Semilight", 28F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(29)))), ((int)(((byte)(119)))));
            this.lblSubtitle.Location = new System.Drawing.Point(5, 21);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(291, 51);
            this.lblSubtitle.TabIndex = 11;
            this.lblSubtitle.Text = "Amount payable";
            // 
            // tbxName
            // 
            this.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxName.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.tbxName.Location = new System.Drawing.Point(553, 208);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(229, 27);
            this.tbxName.TabIndex = 21;
            // 
            // mtbxMM
            // 
            this.mtbxMM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbxMM.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.mtbxMM.Location = new System.Drawing.Point(553, 109);
            this.mtbxMM.Mask = "00";
            this.mtbxMM.Name = "mtbxMM";
            this.mtbxMM.PromptChar = 'M';
            this.mtbxMM.Size = new System.Drawing.Size(62, 27);
            this.mtbxMM.TabIndex = 19;
            // 
            // mtbxCard
            // 
            this.mtbxCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbxCard.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.mtbxCard.Location = new System.Drawing.Point(553, 58);
            this.mtbxCard.Mask = "0000 0000 0000 0000";
            this.mtbxCard.Name = "mtbxCard";
            this.mtbxCard.PromptChar = 'X';
            this.mtbxCard.Size = new System.Drawing.Size(229, 27);
            this.mtbxCard.TabIndex = 20;
            this.mtbxCard.ValidatingType = typeof(int);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblName.ForeColor = System.Drawing.Color.Gray;
            this.lblName.Location = new System.Drawing.Point(549, 171);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(106, 21);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name on card";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(549, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Card Information";
            // 
            // lblSeparator
            // 
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblSeparator.ForeColor = System.Drawing.Color.Gray;
            this.lblSeparator.Location = new System.Drawing.Point(617, 112);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(16, 21);
            this.lblSeparator.TabIndex = 18;
            this.lblSeparator.Text = "/";
            // 
            // mtbxYYYY
            // 
            this.mtbxYYYY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbxYYYY.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.mtbxYYYY.Location = new System.Drawing.Point(635, 109);
            this.mtbxYYYY.Mask = "0000";
            this.mtbxYYYY.Name = "mtbxYYYY";
            this.mtbxYYYY.PromptChar = 'Y';
            this.mtbxYYYY.Size = new System.Drawing.Size(62, 27);
            this.mtbxYYYY.TabIndex = 19;
            // 
            // mtbxCCC
            // 
            this.mtbxCCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbxCCC.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.mtbxCCC.Location = new System.Drawing.Point(719, 109);
            this.mtbxCCC.Mask = "000";
            this.mtbxCCC.Name = "mtbxCCC";
            this.mtbxCCC.PromptChar = 'C';
            this.mtbxCCC.Size = new System.Drawing.Size(63, 27);
            this.mtbxCCC.TabIndex = 19;
            // 
            // CardPaymentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.mtbxCCC);
            this.Controls.Add(this.mtbxYYYY);
            this.Controls.Add(this.mtbxMM);
            this.Controls.Add(this.mtbxCard);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblSubtitle);
            this.Name = "CardPaymentUserControl";
            this.Size = new System.Drawing.Size(820, 293);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.MaskedTextBox mtbxMM;
        private System.Windows.Forms.MaskedTextBox mtbxCard;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.MaskedTextBox mtbxYYYY;
        private System.Windows.Forms.MaskedTextBox mtbxCCC;
    }
}
