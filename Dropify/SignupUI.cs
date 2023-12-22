using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dropify
{
    public partial class SignupUI : BaseForm
    {

        private Dictionary<string, List<string>> GovtIDType;

        public SignupUI()
        {
            InitializeComponent();
            base.TitlebarColorInt = 18944;
            base.BorderColorInt = 18944;
            base.WindowCorner = 3;

            dtpDOB.MaxDate = DateTime.Today.AddYears(-13);

            pbxCaptcha.Image = CaptchaProvider.GetCaptchaImage();

            tbxCaptcha.Text = CaptchaProvider.LastCaptcha;


            GovtIDType = new Dictionary<string, List<string>>
            {
                {"Australia", new List<string> {"Passport", "Driving License"}},
                {"Bangladesh", new List<string> {"NID"}},
                {"Canada", new List<string> {"Passport", "Driving License"}},
                {"Germany", new List<string> {"NID", "Passport"}},
                {"United States", new List<string> {"SSN", "Driving License", "Passport"}}
            };


        }

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









        private void btnPassToggle_Click(object sender, EventArgs e)
        {

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

            tbxCaptcha.Text = CaptchaProvider.LastCaptcha;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SigninUI signinUI = new SigninUI();
            signinUI.Show();
            this.Hide();
        }

        private void btnSetAddress_Click(object sender, EventArgs e)
        {
            AddressPicker userAddress = new AddressPicker("user");
            userAddress.Show();
            
        }
    }
}
