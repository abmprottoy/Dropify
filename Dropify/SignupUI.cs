using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dropify
{
    public partial class SignupUI : BaseForm
    {

        public static readonly Dictionary<string, List<string>> GovtIDType = new Dictionary<string, List<string>>
        {
            {"Australia", new List<string> {"Passport", "Driving License"}},
            {"Bangladesh", new List<string> {"NID"}},
            {"Canada", new List<string> {"Passport", "Driving License"}},
            {"Germany", new List<string> {"NID", "Passport"}},
            {"United States", new List<string> {"SSN", "Driving License", "Passport"}}
        };

        public User ToBeUser = new User();
        public string filePath;
        public string capctchaText;
        public string selectedGender;
        public bool isFirstNameEmpty = true;
        public bool isLastNameEmpty = true;
        public bool isEmailEmpty = true;
        public bool isEmailValid;
        public bool isPhoneEmpty = true;
        public bool isGovtIDEmpty = true;
        public bool isGenderSelected;
        public bool isAddressEmpty = true;
        public bool isPasswordEmpty = true;
        public bool isConfirmPasswordEmpty = true;
        public bool isPasswordValid;
        public bool isPasswordMatched;
        public bool isCaptchaEmpty = true;
        public bool isCaptchaValid;
        public bool isTermsAccepted;


        public SignupUI()
        {
            InitializeComponent();
            InitializeTitlebar();
            InitializeValidValues();






        }

        private void InitializeValidValues()
        {

            dtpDOB.MaxDate = DateTime.Today.AddYears(-13);

            pbxCaptcha.Image = CaptchaProvider.GetCaptchaImage();

            capctchaText = CaptchaProvider.LastCaptcha;

            cbxCountry.SelectedIndex = 0;
        }

        private void InitializeTitlebar()
        {
            base.TitlebarColorInt = 18944;
            base.BorderColorInt = 18944;
            base.WindowCorner = 3;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SigninUI signinUI = new SigninUI();
            signinUI.Show();
            this.Hide();
        }

        
        #region Image Chooser
        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                openFileDialog.Title = "Choose a square image file below 150 KB";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    if (IsValidImage(filePath))
                    {
                        pbxUserImage.Image = Image.FromFile(filePath);
                        pbxUserImage.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        MessageBox.Show("Invalid image format, size, or resolution. Please choose another image.", "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private bool IsValidImage(string filePath)
        {
            try
            {
                using (Image image = Image.FromFile(filePath))
                {
                    // Check valid formats
                    if (Path.GetExtension(filePath).Equals(".jpg", StringComparison.OrdinalIgnoreCase) ||
                        Path.GetExtension(filePath).Equals(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                        Path.GetExtension(filePath).Equals(".png", StringComparison.OrdinalIgnoreCase))
                    {
                        // Check if the image is larger than 100x100 pixels
                        if (image.Width >= 100 && image.Height >= 100)
                        {
                            // Check if the image size is under 150 KB
                            FileInfo fileInfo = new FileInfo(filePath);
                            if (fileInfo.Length <= 150 * 1024) // 150 KB in bytes
                            {
                                // Check if the image is in square format
                                return image.Width == image.Height;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could not load the image file. Verify that file exists or another program is not using the image.", "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        #endregion Image Chooser


        private void cbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbxCountry.SelectedIndex;
            cbxPhone.SelectedIndex = selectedIndex;
            cbxGovtIDType.Items.Clear();
            string selectedCountry = cbxCountry.SelectedItem as string;

            // Check if the selected country is in the dictionary
            if (GovtIDType.ContainsKey(selectedCountry))
            {
                // Populate the ID Types ComboBox with the selected country's ID types
                cbxGovtIDType.Items.AddRange(GovtIDType[selectedCountry].ToArray());
                cbxGovtIDType.SelectedIndex = 0;
            }
        }










        private void mtbxPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbxPhone.MaskFull)
            {
                ttMaskedPhoneNum.ToolTipTitle = "Input Rejected - Too Much Data";
                ttMaskedPhoneNum.Show("You cannot enter any more data into the date field. Delete some characters in order to insert more data.", mtbxPhone, 30, -93, 5000);
            }
            else if (e.Position == mtbxPhone.Mask.Length)
            {
                ttMaskedPhoneNum.ToolTipTitle = "Input Rejected - End of Field";
                ttMaskedPhoneNum.Show("You cannot add extra characters to the end of this\nphone number field.", mtbxPhone, 30, -93, 5000);
            }
            else
            {
                ttMaskedPhoneNum.ToolTipTitle = "Input Rejected";
                ttMaskedPhoneNum.Show("You can only add numeric characters (0-9) into this date field.\nNo alpha keys are allowed.", mtbxPhone, 30, -93, 5000);
            }
        }
        private void mtbxPhone_KeyDown(object sender, KeyEventArgs e)
        {
            ttMaskedPhoneNum.Hide(mtbxPhone);
        }

        private void btnTryAnother_Click(object sender, EventArgs e)
        {
            pbxCaptcha.Image = CaptchaProvider.GetCaptchaImage();


            capctchaText = CaptchaProvider.LastCaptcha;
        }

        public AddressPickerUI userAddress;
        private void btnSetAddress_Click(object sender, EventArgs e)
        {
            using (userAddress = new AddressPickerUI("user", cbxCountry.SelectedIndex))
            {
                userAddress.ShowDialog();
                tbxAddress.Text = userAddress.address.ToString();
            }
            
        }

        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {
            
            isFirstNameEmpty = string.IsNullOrWhiteSpace(tbxFirstName.Text);
            Console.WriteLine(isFirstNameEmpty);
        }

        private void tbxLastName_TextChanged(object sender, EventArgs e)
        {
            isLastNameEmpty = string.IsNullOrWhiteSpace(tbxLastName.Text);
        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {
            isEmailEmpty = string.IsNullOrWhiteSpace(tbxEmail.Text);
            if (!isEmailEmpty)
            {
                isEmailValid = IsValidEmail(tbxEmail.Text);
            }
            
            
        }

        static bool IsValidEmail(string email)
        {
            try
            {
                // Attempt to create a MailAddress instance
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                // The email address is not in a valid format
                return false;
            }
        }

        private void mtbxPhone_TextChanged(object sender, EventArgs e)
        {
            isPhoneEmpty = string.IsNullOrWhiteSpace(mtbxPhone.Text.Replace(mtbxPhone.PromptChar.ToString(), ""));
        }

        private void tbxGovtID_TextChanged(object sender, EventArgs e)
        {
            isGovtIDEmpty = string.IsNullOrWhiteSpace(tbxGovtID.Text);
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMale.Checked || rbFemale.Checked || rbOther.Checked)
            {
                isGenderSelected = true;
            }
            else
            {
                isGenderSelected = false;
            }

            UpdateGender();

        }


        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked || rbFemale.Checked || rbOther.Checked)
            {
                isGenderSelected = true;
            }
            else
            {
                isGenderSelected = false;
            }

            UpdateGender();
        
        }

        private void rbOther_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked || rbFemale.Checked || rbOther.Checked)
            {
                isGenderSelected = true;
            }
            else
            {
                isGenderSelected = false;
            }
            
            UpdateGender();

        }

        private void UpdateGender()
        {
            if (rbMale.Checked)
            {
                selectedGender = "Male";
            }else if (rbFemale.Checked)
            {
                selectedGender = "Female";
            }else if (rbOther.Checked)
            {
                selectedGender = "Other";
            }
            
        }
























        private void btnPassToggle_Click(object sender, EventArgs e)
        {
            TogglePasswordView();
        }

        private void TogglePasswordView()
        {
            if (tbxPassword.PasswordChar == '●')
            {
                tbxPassword.PasswordChar = '\0';
                btnPassToggle.Text = "";
            }
            else
            {
                tbxPassword.PasswordChar = '●';
                btnPassToggle.Text = "";
            }
        }
        private void btnConfirmPassToggle_Click(object sender, EventArgs e)
        {
            ToggleConfirmPasswordView();
        }

        private void ToggleConfirmPasswordView()
        {
            if (tbxConfirmPassword.PasswordChar == '●')
            {
                tbxConfirmPassword.PasswordChar = '\0';
                btnConfirmPassToggle.Text = "";
            }
            else
            {
                tbxConfirmPassword.PasswordChar = '●';
                btnConfirmPassToggle.Text = "";
            }
        }

        private void tbxAddress_TextChanged(object sender, EventArgs e)
        {
            int compareResult = string.Compare(tbxAddress.Text, "None");

            if(compareResult == 0)
            {
                isAddressEmpty = true;
            }
            else
            {
                isAddressEmpty = false;
            }
        }
        private void tbxAddress_MouseHover(object sender, EventArgs e)
        {
            ttAddress.Show(tbxAddress.Text,tbxAddress);
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            isPasswordEmpty = string.IsNullOrWhiteSpace(tbxPassword.Text);
            isPasswordValid = IsValidPassword(tbxPassword.Text);

            if (!isPasswordValid)
            {
                ttPasswordValid.ToolTipTitle = "Password Invalid";
                ttPasswordValid.Show("Password must:\n" +
                    " - Be at least 8 characters long\n" +
                    " - Contain at least one uppercase letter\n" +
                    " - Contain at least one lowercase letter\n" +
                    " - Contain at least one digit\n" +
                    " - Contain at least one of the special characters: @$!% *? &", tbxPassword,30,23,5000);
            }

        }

        private void tbxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            isConfirmPasswordEmpty = string.IsNullOrWhiteSpace(tbxConfirmPassword.Text);
            int compareResult = string.Compare(tbxPassword.Text, tbxConfirmPassword.Text);
            if(compareResult == 0)
            {
                isPasswordMatched = true;
                ttPasswordMatch.Hide(tbxConfirmPassword);
            }
            else
            {
                isPasswordMatched = false;
                ttPasswordMatch.ToolTipTitle = "Password Mismatch";
                ttPasswordMatch.Show("Confirm password must match with Password", tbxConfirmPassword, 30, 23, 5000);
            }

        }


        static bool IsValidPassword(string password)
        {
            // Define the regular expression for a valid password
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&]).{8,}$";

            // Create a Regex object
            Regex regex = new Regex(pattern);

            // Use the IsMatch method to check if the password matches the pattern
            return regex.IsMatch(password);
        }

        private void tbxCaptcha_TextChanged(object sender, EventArgs e)
        {
            isCaptchaEmpty = string.IsNullOrWhiteSpace(tbxCaptcha.Text);
            int compareResult = string.Compare(tbxCaptcha.Text, capctchaText);
            if(compareResult == 0)
            {
                isCaptchaValid = true;
            }
            else
            {
                isCaptchaValid = false;
            }
            
        }

        private void chbxTerms_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbxTerms.Checked)
            {
                isTermsAccepted = true;
            }
            else
            {
                isTermsAccepted = false;
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {

            
            if (isFirstNameEmpty)
            {
                MessageBox.Show("First name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (isLastNameEmpty)
            {
                MessageBox.Show("Last name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (isEmailEmpty)
            {
                MessageBox.Show("Email cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!isEmailValid)
            {
                MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (isPhoneEmpty)
            {
                MessageBox.Show("Phone cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (isGovtIDEmpty)
            {
                MessageBox.Show("Government ID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!isGenderSelected)
            {
                MessageBox.Show("Please select a gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (isAddressEmpty)
            {
                MessageBox.Show("Address cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (isPasswordEmpty)
            {
                MessageBox.Show("Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!isPasswordValid)
            {
                MessageBox.Show("Invalid password format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (isConfirmPasswordEmpty)
            {
                MessageBox.Show("Confirm password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!isPasswordMatched)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (isCaptchaEmpty)
            {
                MessageBox.Show("Captcha cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!isCaptchaValid)
            {
                MessageBox.Show("Invalid captcha.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!isTermsAccepted)
            {
                MessageBox.Show("Please accept the terms and conditions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (AllValid() == true)
            {
                
                ToBeUser.ProfileID = Guid.NewGuid();
                ToBeUser.FirstName = tbxFirstName.Text;
                ToBeUser.LastName = tbxLastName.Text;
                ToBeUser.Email = tbxEmail.Text;
                ToBeUser.CountryCode = cbxPhone.Text;
                ToBeUser.Phone = mtbxPhone.Text;
                ToBeUser.address = new Address
                {
                    AddressID = Guid.NewGuid(),
                    Country = userAddress.address.Country,
                    City = userAddress.address.City,
                    Area = userAddress.address.Area,
                    Zip = userAddress.address.Zip,
                    Landmark = userAddress.address.Landmark
                };
                ToBeUser.ProfilePicture = filePath != null ? Image.FromFile(filePath) : Properties.Resources.Avatar_Default;
                ToBeUser.DOB = dtpDOB.Value;
                ToBeUser.GovtIDType = cbxGovtIDType.SelectedItem.ToString();
                ToBeUser.GovtID = tbxGovtID.Text;
                ToBeUser.PasswordHash = HashProvider.CalculateSHA256(tbxConfirmPassword.Text);
                ToBeUser.Role = "User";
                ToBeUser.Gender = selectedGender;

                if (ToBeUser.UserSignUp(ToBeUser))
                {
                    SecurityUI securityUI = new SecurityUI(ToBeUser.ProfileID, ToBeUser.Email, 0);
                    this.Hide();
                    securityUI.Show();
                }
            }

        }

        private bool AllValid()
        {
            if(!isFirstNameEmpty && !isLastNameEmpty && !isEmailEmpty && isEmailValid && !isPhoneEmpty && !isGovtIDEmpty && isGenderSelected
                && !isAddressEmpty && !isPasswordEmpty && !isConfirmPasswordEmpty && isPasswordValid && isPasswordMatched && !isCaptchaEmpty
                && isCaptchaValid && isTermsAccepted)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
