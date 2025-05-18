
namespace Dropify
{
    partial class SystemInformationUI
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
            this.modernListBox1 = new ModernListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // modernListBox1
            // 
            this.modernListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(168)))));
            this.modernListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modernListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.modernListBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.modernListBox1.ForeColor = System.Drawing.Color.White;
            this.modernListBox1.FormattingEnabled = true;
            this.modernListBox1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(224)))));
            this.modernListBox1.ItemHeight = 45;
            this.modernListBox1.Items.AddRange(new object[] {
            "System Information",
            "System Maintenence"});
            this.modernListBox1.ItemTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.modernListBox1.ItemTextColor = System.Drawing.Color.White;
            this.modernListBox1.Location = new System.Drawing.Point(0, 39);
            this.modernListBox1.Margin = new System.Windows.Forms.Padding(0);
            this.modernListBox1.Name = "modernListBox1";
            this.modernListBox1.SelectedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(224)))));
            this.modernListBox1.SelectedItemTextColor = System.Drawing.SystemColors.HighlightText;
            this.modernListBox1.Size = new System.Drawing.Size(272, 135);
            this.modernListBox1.TabIndex = 0;
            this.modernListBox1.TextPadding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.modernListBox1.SelectedIndexChanged += new System.EventHandler(this.modernListBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(96)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.modernListBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 300);
            this.panel1.TabIndex = 1;
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(265, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(835, 300);
            this.pnlContent.TabIndex = 2;
            // 
            // SystemInformationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel1);
            this.Name = "SystemInformationUI";
            this.Size = new System.Drawing.Size(1100, 300);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ModernListBox modernListBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlContent;
    }
}
