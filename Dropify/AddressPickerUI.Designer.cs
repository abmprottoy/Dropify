
namespace Dropify
{
    partial class AddressPickerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressPickerUI));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tbxLandmark = new System.Windows.Forms.TextBox();
            this.lblLandmark = new System.Windows.Forms.Label();
            this.tbxZip = new System.Windows.Forms.TextBox();
            this.tbxArea = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cbxCountry = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.pnlTitle.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(100)))));
            this.pnlTitle.Controls.Add(this.lbl);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(891, 110);
            this.pnlTitle.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(23, 25);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(110, 15);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "CHOOSE ADDRESS";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 36F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(105, 65);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "title";
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.tbxLandmark);
            this.pnlContent.Controls.Add(this.lblLandmark);
            this.pnlContent.Controls.Add(this.tbxZip);
            this.pnlContent.Controls.Add(this.tbxArea);
            this.pnlContent.Controls.Add(this.lblCountry);
            this.pnlContent.Controls.Add(this.cbxCountry);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.lblArea);
            this.pnlContent.Controls.Add(this.lblCity);
            this.pnlContent.Controls.Add(this.btnSave);
            this.pnlContent.Controls.Add(this.cbxCity);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 110);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(891, 361);
            this.pnlContent.TabIndex = 7;
            // 
            // tbxLandmark
            // 
            this.tbxLandmark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxLandmark.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.tbxLandmark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tbxLandmark.Location = new System.Drawing.Point(160, 230);
            this.tbxLandmark.MaxLength = 256;
            this.tbxLandmark.Multiline = true;
            this.tbxLandmark.Name = "tbxLandmark";
            this.tbxLandmark.Size = new System.Drawing.Size(281, 66);
            this.tbxLandmark.TabIndex = 5;
            // 
            // lblLandmark
            // 
            this.lblLandmark.AutoSize = true;
            this.lblLandmark.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblLandmark.ForeColor = System.Drawing.Color.Gray;
            this.lblLandmark.Location = new System.Drawing.Point(22, 231);
            this.lblLandmark.Name = "lblLandmark";
            this.lblLandmark.Size = new System.Drawing.Size(77, 21);
            this.lblLandmark.TabIndex = 38;
            this.lblLandmark.Text = "Landmark";
            // 
            // tbxZip
            // 
            this.tbxZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxZip.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.tbxZip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tbxZip.Location = new System.Drawing.Point(160, 179);
            this.tbxZip.MaxLength = 15;
            this.tbxZip.Name = "tbxZip";
            this.tbxZip.Size = new System.Drawing.Size(281, 27);
            this.tbxZip.TabIndex = 4;
            // 
            // tbxArea
            // 
            this.tbxArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxArea.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.tbxArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tbxArea.Location = new System.Drawing.Point(160, 130);
            this.tbxArea.MaxLength = 50;
            this.tbxArea.Name = "tbxArea";
            this.tbxArea.Size = new System.Drawing.Size(281, 27);
            this.tbxArea.TabIndex = 3;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblCountry.ForeColor = System.Drawing.Color.Gray;
            this.lblCountry.Location = new System.Drawing.Point(22, 29);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(65, 21);
            this.lblCountry.TabIndex = 16;
            this.lblCountry.Text = "Country";
            // 
            // cbxCountry
            // 
            this.cbxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCountry.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.cbxCountry.FormattingEnabled = true;
            this.cbxCountry.Items.AddRange(new object[] {
            "Australia",
            "Bangladesh",
            "Canada",
            "Germany",
            "United States"});
            this.cbxCountry.Location = new System.Drawing.Point(160, 27);
            this.cbxCountry.Name = "cbxCountry";
            this.cbxCountry.Size = new System.Drawing.Size(281, 28);
            this.cbxCountry.Sorted = true;
            this.cbxCountry.TabIndex = 1;
            this.cbxCountry.SelectedIndexChanged += new System.EventHandler(this.cbxCountry_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(22, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Zip";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblArea.ForeColor = System.Drawing.Color.Gray;
            this.lblArea.Location = new System.Drawing.Point(22, 131);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(41, 21);
            this.lblArea.TabIndex = 12;
            this.lblArea.Text = "Area";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblCity.ForeColor = System.Drawing.Color.Gray;
            this.lblCity.Location = new System.Drawing.Point(22, 81);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(36, 21);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(366, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxCity
            // 
            this.cbxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCity.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Items.AddRange(new object[] {
            "Australia",
            "Bangladesh",
            "Canada",
            "Germany",
            "United States"});
            this.cbxCity.Location = new System.Drawing.Point(160, 79);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(281, 28);
            this.cbxCity.TabIndex = 2;
            this.cbxCity.SelectedIndexChanged += new System.EventHandler(this.cbxCity_SelectedIndexChanged);
            // 
            // AddressPickerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 471);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddressPickerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Address";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cbxCountry;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbxArea;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxLandmark;
        private System.Windows.Forms.Label lblLandmark;
        private System.Windows.Forms.TextBox tbxZip;
        private System.Windows.Forms.Button btnSave;
    }
}