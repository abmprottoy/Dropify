
namespace Dropify
{
    partial class SystemMaintenenceUserControl
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
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMaintenence = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBringOnline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.AutoSize = true;
            this.lblServerStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblServerStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.lblServerStatus.Location = new System.Drawing.Point(26, 115);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(84, 21);
            this.lblServerStatus.TabIndex = 10;
            this.lblServerStatus.Text = "Connected";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 18F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.label4.Location = new System.Drawing.Point(24, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Current Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 18F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.label3.Location = new System.Drawing.Point(24, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "server maintenence";
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
            this.btnMaintenence.Location = new System.Drawing.Point(30, 215);
            this.btnMaintenence.Name = "btnMaintenence";
            this.btnMaintenence.Size = new System.Drawing.Size(209, 31);
            this.btnMaintenence.TabIndex = 11;
            this.btnMaintenence.Text = "turn off for maintenence";
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
            this.label1.Location = new System.Drawing.Point(24, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Change User Access";
            // 
            // btnBringOnline
            // 
            this.btnBringOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(117)))), ((int)(((byte)(70)))));
            this.btnBringOnline.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(117)))), ((int)(((byte)(70)))));
            this.btnBringOnline.FlatAppearance.BorderSize = 2;
            this.btnBringOnline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBringOnline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBringOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBringOnline.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBringOnline.ForeColor = System.Drawing.Color.White;
            this.btnBringOnline.Location = new System.Drawing.Point(255, 215);
            this.btnBringOnline.Name = "btnBringOnline";
            this.btnBringOnline.Size = new System.Drawing.Size(209, 31);
            this.btnBringOnline.TabIndex = 11;
            this.btnBringOnline.Text = "bring back online";
            this.btnBringOnline.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBringOnline.UseVisualStyleBackColor = false;
            this.btnBringOnline.Click += new System.EventHandler(this.btnBringOnline_Click);
            // 
            // SystemMaintenenceUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnBringOnline);
            this.Controls.Add(this.btnMaintenence);
            this.Controls.Add(this.lblServerStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "SystemMaintenenceUserControl";
            this.Size = new System.Drawing.Size(835, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServerStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMaintenence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBringOnline;
    }
}
