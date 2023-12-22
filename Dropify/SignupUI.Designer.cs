
namespace Dropify
{
    partial class SignupUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBlankSpacerSignUp = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.chbxTerms = new System.Windows.Forms.CheckBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbxGovtIDType = new System.Windows.Forms.ComboBox();
            this.lblGovtIDType = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.btnConfirmPassToggle = new System.Windows.Forms.Button();
            this.btnPassToggle = new System.Windows.Forms.Button();
            this.btnSetAddress = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnTryAnother = new System.Windows.Forms.Button();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.pbxCaptcha = new System.Windows.Forms.PictureBox();
            this.lblCaptcha = new System.Windows.Forms.Label();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.mtbxPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cbxCountry = new System.Windows.Forms.ComboBox();
            this.cbxPhone = new System.Windows.Forms.ComboBox();
            this.tbxCaptcha = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbxGovtID = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblGovtID = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.pbxUserImage = new System.Windows.Forms.PictureBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.ttMaskedPhoneNum = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCaptcha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 110);
            this.panel1.TabIndex = 0;
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
            this.lblTitle.Size = new System.Drawing.Size(180, 65);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "sign up";
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
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblBlankSpacerSignUp);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.chbxTerms);
            this.panel2.Controls.Add(this.lblConfirmPassword);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.cbxGovtIDType);
            this.panel2.Controls.Add(this.lblGovtIDType);
            this.panel2.Controls.Add(this.tbxAddress);
            this.panel2.Controls.Add(this.btnConfirmPassToggle);
            this.panel2.Controls.Add(this.btnPassToggle);
            this.panel2.Controls.Add(this.btnSetAddress);
            this.panel2.Controls.Add(this.lblAddress);
            this.panel2.Controls.Add(this.btnTryAnother);
            this.panel2.Controls.Add(this.tbxConfirmPassword);
            this.panel2.Controls.Add(this.tbxPassword);
            this.panel2.Controls.Add(this.pbxCaptcha);
            this.panel2.Controls.Add(this.lblCaptcha);
            this.panel2.Controls.Add(this.rbOther);
            this.panel2.Controls.Add(this.rbFemale);
            this.panel2.Controls.Add(this.rbMale);
            this.panel2.Controls.Add(this.lblGender);
            this.panel2.Controls.Add(this.dtpDOB);
            this.panel2.Controls.Add(this.lblDOB);
            this.panel2.Controls.Add(this.mtbxPhone);
            this.panel2.Controls.Add(this.lblCountry);
            this.panel2.Controls.Add(this.cbxCountry);
            this.panel2.Controls.Add(this.cbxPhone);
            this.panel2.Controls.Add(this.tbxCaptcha);
            this.panel2.Controls.Add(this.lblPhone);
            this.panel2.Controls.Add(this.tbxGovtID);
            this.panel2.Controls.Add(this.tbxEmail);
            this.panel2.Controls.Add(this.lblGovtID);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.btnChooseImage);
            this.panel2.Controls.Add(this.tbxLastName);
            this.panel2.Controls.Add(this.lblLastName);
            this.panel2.Controls.Add(this.lblSubtitle);
            this.panel2.Controls.Add(this.tbxFirstName);
            this.panel2.Controls.Add(this.pbxUserImage);
            this.panel2.Controls.Add(this.lblFirstName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 396);
            this.panel2.TabIndex = 6;
            // 
            // lblBlankSpacerSignUp
            // 
            this.lblBlankSpacerSignUp.AutoSize = true;
            this.lblBlankSpacerSignUp.Location = new System.Drawing.Point(381, 1217);
            this.lblBlankSpacerSignUp.Name = "lblBlankSpacerSignUp";
            this.lblBlankSpacerSignUp.Size = new System.Drawing.Size(0, 13);
            this.lblBlankSpacerSignUp.TabIndex = 35;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(0)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(384, 1127);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 27);
            this.btnNext.TabIndex = 34;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // chbxTerms
            // 
            this.chbxTerms.AutoSize = true;
            this.chbxTerms.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.chbxTerms.Location = new System.Drawing.Point(384, 1048);
            this.chbxTerms.Name = "chbxTerms";
            this.chbxTerms.Size = new System.Drawing.Size(451, 24);
            this.chbxTerms.TabIndex = 33;
            this.chbxTerms.Text = "I agree with Dropify Inc\'s Terms and Conditions and Privacy Policy.";
            this.chbxTerms.UseVisualStyleBackColor = true;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblConfirmPassword.Location = new System.Drawing.Point(378, 879);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(133, 21);
            this.lblConfirmPassword.TabIndex = 32;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblPassword.Location = new System.Drawing.Point(380, 801);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 21);
            this.lblPassword.TabIndex = 32;
            this.lblPassword.Text = "Password";
            // 
            // cbxGovtIDType
            // 
            this.cbxGovtIDType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGovtIDType.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.cbxGovtIDType.FormattingEnabled = true;
            this.cbxGovtIDType.Location = new System.Drawing.Point(513, 406);
            this.cbxGovtIDType.Name = "cbxGovtIDType";
            this.cbxGovtIDType.Size = new System.Drawing.Size(281, 28);
            this.cbxGovtIDType.Sorted = true;
            this.cbxGovtIDType.TabIndex = 31;
            // 
            // lblGovtIDType
            // 
            this.lblGovtIDType.AutoSize = true;
            this.lblGovtIDType.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblGovtIDType.ForeColor = System.Drawing.Color.Gray;
            this.lblGovtIDType.Location = new System.Drawing.Point(380, 406);
            this.lblGovtIDType.Name = "lblGovtIDType";
            this.lblGovtIDType.Size = new System.Drawing.Size(96, 21);
            this.lblGovtIDType.TabIndex = 30;
            this.lblGovtIDType.Text = "Govt ID Type";
            // 
            // tbxAddress
            // 
            this.tbxAddress.BackColor = System.Drawing.Color.White;
            this.tbxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAddress.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.tbxAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tbxAddress.Location = new System.Drawing.Point(513, 717);
            this.tbxAddress.MaxLength = 128;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.ReadOnly = true;
            this.tbxAddress.Size = new System.Drawing.Size(196, 27);
            this.tbxAddress.TabIndex = 29;
            this.tbxAddress.Text = "None";
            // 
            // btnConfirmPassToggle
            // 
            this.btnConfirmPassToggle.FlatAppearance.BorderSize = 0;
            this.btnConfirmPassToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPassToggle.Font = new System.Drawing.Font("Segoe Fluent Icons", 10F);
            this.btnConfirmPassToggle.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmPassToggle.Location = new System.Drawing.Point(769, 877);
            this.btnConfirmPassToggle.Name = "btnConfirmPassToggle";
            this.btnConfirmPassToggle.Size = new System.Drawing.Size(25, 25);
            this.btnConfirmPassToggle.TabIndex = 3;
            this.btnConfirmPassToggle.Text = "";
            this.btnConfirmPassToggle.UseVisualStyleBackColor = true;
            this.btnConfirmPassToggle.Click += new System.EventHandler(this.btnPassToggle_Click);
            // 
            // btnPassToggle
            // 
            this.btnPassToggle.FlatAppearance.BorderSize = 0;
            this.btnPassToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassToggle.Font = new System.Drawing.Font("Segoe Fluent Icons", 10F);
            this.btnPassToggle.ForeColor = System.Drawing.Color.Black;
            this.btnPassToggle.Location = new System.Drawing.Point(769, 799);
            this.btnPassToggle.Name = "btnPassToggle";
            this.btnPassToggle.Size = new System.Drawing.Size(25, 25);
            this.btnPassToggle.TabIndex = 3;
            this.btnPassToggle.Text = "";
            this.btnPassToggle.UseVisualStyleBackColor = true;
            this.btnPassToggle.Click += new System.EventHandler(this.btnPassToggle_Click);
            // 
            // btnSetAddress
            // 
            this.btnSetAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSetAddress.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSetAddress.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(0)))));
            this.btnSetAddress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSetAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAddress.ForeColor = System.Drawing.Color.Black;
            this.btnSetAddress.Location = new System.Drawing.Point(715, 717);
            this.btnSetAddress.Name = "btnSetAddress";
            this.btnSetAddress.Size = new System.Drawing.Size(79, 27);
            this.btnSetAddress.TabIndex = 28;
            this.btnSetAddress.Text = "Set Address";
            this.btnSetAddress.UseVisualStyleBackColor = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblAddress.ForeColor = System.Drawing.Color.Gray;
            this.lblAddress.Location = new System.Drawing.Point(380, 717);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 21);
            this.lblAddress.TabIndex = 27;
            this.lblAddress.Text = "Address";
            // 
            // btnTryAnother
            // 
            this.btnTryAnother.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTryAnother.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTryAnother.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(0)))));
            this.btnTryAnother.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnTryAnother.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTryAnother.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTryAnother.ForeColor = System.Drawing.Color.Black;
            this.btnTryAnother.Location = new System.Drawing.Point(715, 965);
            this.btnTryAnother.Name = "btnTryAnother";
            this.btnTryAnother.Size = new System.Drawing.Size(79, 27);
            this.btnTryAnother.TabIndex = 26;
            this.btnTryAnother.Text = "Try Another";
            this.btnTryAnother.UseVisualStyleBackColor = false;
            this.btnTryAnother.Click += new System.EventHandler(this.btnTryAnother_Click);
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.BackColor = System.Drawing.Color.White;
            this.tbxConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxConfirmPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.tbxConfirmPassword.Location = new System.Drawing.Point(513, 877);
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.PasswordChar = '●';
            this.tbxConfirmPassword.Size = new System.Drawing.Size(250, 27);
            this.tbxConfirmPassword.TabIndex = 2;
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.White;
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.ForeColor = System.Drawing.Color.White;
            this.tbxPassword.Location = new System.Drawing.Point(513, 799);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '●';
            this.tbxPassword.Size = new System.Drawing.Size(250, 27);
            this.tbxPassword.TabIndex = 2;
            // 
            // pbxCaptcha
            // 
            this.pbxCaptcha.Location = new System.Drawing.Point(513, 966);
            this.pbxCaptcha.Name = "pbxCaptcha";
            this.pbxCaptcha.Size = new System.Drawing.Size(100, 25);
            this.pbxCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCaptcha.TabIndex = 25;
            this.pbxCaptcha.TabStop = false;
            // 
            // lblCaptcha
            // 
            this.lblCaptcha.AutoSize = true;
            this.lblCaptcha.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblCaptcha.ForeColor = System.Drawing.Color.Gray;
            this.lblCaptcha.Location = new System.Drawing.Point(380, 966);
            this.lblCaptcha.Name = "lblCaptcha";
            this.lblCaptcha.Size = new System.Drawing.Size(66, 21);
            this.lblCaptcha.TabIndex = 24;
            this.lblCaptcha.Text = "Captcha";
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(743, 643);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(51, 17);
            this.rbOther.TabIndex = 23;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Other";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(626, 643);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 22;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(513, 643);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 21;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblGender.ForeColor = System.Drawing.Color.Gray;
            this.lblGender.Location = new System.Drawing.Point(380, 640);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 21);
            this.lblGender.TabIndex = 20;
            this.lblGender.Text = "Gender";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarFont = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.dtpDOB.Location = new System.Drawing.Point(513, 565);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(281, 23);
            this.dtpDOB.TabIndex = 19;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblDOB.ForeColor = System.Drawing.Color.Gray;
            this.lblDOB.Location = new System.Drawing.Point(380, 564);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(42, 21);
            this.lblDOB.TabIndex = 18;
            this.lblDOB.Text = "DOB";
            // 
            // mtbxPhone
            // 
            this.mtbxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbxPhone.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.mtbxPhone.Location = new System.Drawing.Point(601, 332);
            this.mtbxPhone.Mask = "000-00000000";
            this.mtbxPhone.Name = "mtbxPhone";
            this.mtbxPhone.PromptChar = ' ';
            this.mtbxPhone.Size = new System.Drawing.Size(193, 27);
            this.mtbxPhone.TabIndex = 17;
            this.mtbxPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbxPhone_MaskInputRejected);
            this.mtbxPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbxPhone_KeyDown);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblCountry.ForeColor = System.Drawing.Color.Gray;
            this.lblCountry.Location = new System.Drawing.Point(380, 264);
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
            this.cbxCountry.Location = new System.Drawing.Point(513, 263);
            this.cbxCountry.Name = "cbxCountry";
            this.cbxCountry.Size = new System.Drawing.Size(281, 28);
            this.cbxCountry.Sorted = true;
            this.cbxCountry.TabIndex = 15;
            this.cbxCountry.SelectedIndexChanged += new System.EventHandler(this.cbxCountry_SelectedIndexChanged);
            // 
            // cbxPhone
            // 
            this.cbxPhone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPhone.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.cbxPhone.FormattingEnabled = true;
            this.cbxPhone.Items.AddRange(new object[] {
            "AU (+61)",
            "BD (+88)",
            "CA (+1)",
            "DE (+49)",
            "US (+1)"});
            this.cbxPhone.Location = new System.Drawing.Point(513, 332);
            this.cbxPhone.Name = "cbxPhone";
            this.cbxPhone.Size = new System.Drawing.Size(82, 28);
            this.cbxPhone.Sorted = true;
            this.cbxPhone.TabIndex = 14;
            // 
            // tbxCaptcha
            // 
            this.tbxCaptcha.BackColor = System.Drawing.Color.White;
            this.tbxCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCaptcha.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.tbxCaptcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tbxCaptcha.Location = new System.Drawing.Point(619, 965);
            this.tbxCaptcha.MaxLength = 128;
            this.tbxCaptcha.Name = "tbxCaptcha";
            this.tbxCaptcha.Size = new System.Drawing.Size(90, 27);
            this.tbxCaptcha.TabIndex = 13;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblPhone.ForeColor = System.Drawing.Color.Gray;
            this.lblPhone.Location = new System.Drawing.Point(380, 334);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(54, 21);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "Phone";
            // 
            // tbxGovtID
            // 
            this.tbxGovtID.BackColor = System.Drawing.Color.White;
            this.tbxGovtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxGovtID.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.tbxGovtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tbxGovtID.Location = new System.Drawing.Point(513, 481);
            this.tbxGovtID.MaxLength = 128;
            this.tbxGovtID.Name = "tbxGovtID";
            this.tbxGovtID.Size = new System.Drawing.Size(281, 27);
            this.tbxGovtID.TabIndex = 11;
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.White;
            this.tbxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxEmail.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.tbxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tbxEmail.Location = new System.Drawing.Point(513, 198);
            this.tbxEmail.MaxLength = 128;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(281, 27);
            this.tbxEmail.TabIndex = 11;
            // 
            // lblGovtID
            // 
            this.lblGovtID.AutoSize = true;
            this.lblGovtID.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblGovtID.ForeColor = System.Drawing.Color.Gray;
            this.lblGovtID.Location = new System.Drawing.Point(380, 482);
            this.lblGovtID.Name = "lblGovtID";
            this.lblGovtID.Size = new System.Drawing.Size(61, 21);
            this.lblGovtID.TabIndex = 10;
            this.lblGovtID.Text = "Govt ID";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail.Location = new System.Drawing.Point(380, 199);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 21);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnChooseImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnChooseImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(0)))));
            this.btnChooseImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseImage.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.ForeColor = System.Drawing.Color.Black;
            this.btnChooseImage.Location = new System.Drawing.Point(122, 235);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(75, 27);
            this.btnChooseImage.TabIndex = 9;
            this.btnChooseImage.Text = "Browse";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            // 
            // tbxLastName
            // 
            this.tbxLastName.BackColor = System.Drawing.Color.White;
            this.tbxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxLastName.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.tbxLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tbxLastName.Location = new System.Drawing.Point(513, 136);
            this.tbxLastName.MaxLength = 128;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(281, 27);
            this.tbxLastName.TabIndex = 8;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblLastName.ForeColor = System.Drawing.Color.Gray;
            this.lblLastName.Location = new System.Drawing.Point(380, 134);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 21);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(0)))));
            this.lblSubtitle.Location = new System.Drawing.Point(375, 18);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(220, 37);
            this.lblSubtitle.TabIndex = 6;
            this.lblSubtitle.Text = "Enter your details";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.BackColor = System.Drawing.Color.White;
            this.tbxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFirstName.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.tbxFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tbxFirstName.Location = new System.Drawing.Point(513, 75);
            this.tbxFirstName.MaxLength = 128;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(281, 27);
            this.tbxFirstName.TabIndex = 5;
            // 
            // pbxUserImage
            // 
            this.pbxUserImage.Image = ((System.Drawing.Image)(resources.GetObject("pbxUserImage.Image")));
            this.pbxUserImage.Location = new System.Drawing.Point(122, 75);
            this.pbxUserImage.Name = "pbxUserImage";
            this.pbxUserImage.Size = new System.Drawing.Size(150, 150);
            this.pbxUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUserImage.TabIndex = 1;
            this.pbxUserImage.TabStop = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblFirstName.ForeColor = System.Drawing.Color.Gray;
            this.lblFirstName.Location = new System.Drawing.Point(380, 76);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 21);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // ttMaskedPhoneNum
            // 
            this.ttMaskedPhoneNum.IsBalloon = true;
            this.ttMaskedPhoneNum.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // SignupUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(954, 506);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 500);
            this.Name = "SignupUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dropify - Sign Up";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCaptcha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox pbxUserImage;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cbxPhone;
        private System.Windows.Forms.TextBox tbxCaptcha;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cbxCountry;
        private System.Windows.Forms.MaskedTextBox mtbxPhone;
        private System.Windows.Forms.ToolTip ttMaskedPhoneNum;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.PictureBox pbxCaptcha;
        private System.Windows.Forms.Label lblCaptcha;
        private System.Windows.Forms.Button btnTryAnother;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Button btnSetAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cbxGovtIDType;
        private System.Windows.Forms.Label lblGovtIDType;
        private System.Windows.Forms.TextBox tbxGovtID;
        private System.Windows.Forms.Label lblGovtID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox chbxTerms;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Button btnConfirmPassToggle;
        private System.Windows.Forms.Button btnPassToggle;
        private System.Windows.Forms.TextBox tbxConfirmPassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblBlankSpacerSignUp;
    }
}