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
    public partial class PaymentUI : BaseForm
    {
        public bKashUserControl bKashUI;
        public CardPaymentUserControl cardUI;

        public PaymentUI(string paymentMethod, string currency, decimal amount)
        {
            InitializeComponent();

            InitializeUI(paymentMethod);

            bKashUI = new bKashUserControl(amount);
            

            cardUI = new CardPaymentUserControl(paymentMethod, currency, amount);

            if(paymentMethod == "bKash")
            {
                pnlContent.Controls.Add(bKashUI);
            }
            else
            {
                pnlContent.Controls.Add(cardUI);
            }
            

            
        }

        public void InitializeUI(string paymentMethod)
        {
            string selectedMethod = paymentMethod.ToLower();


            switch (selectedMethod)
            {
                case "amex":
                    InitializeTitlebar(13659905);
                    pnlTitle.BackColor = Color.FromArgb(1, 111, 208);
                    lblTitle.Text = "american express";
                    this.Text = "Payment - American Express";
                    this.Icon = Properties.Resources.Icon_BlueAmex;
                    pbxPaymentIcon.Image = (Image)Properties.Resources.ResourceManager.GetObject("Icon_Amex");
                    
                    break;

                case "bkash":
                    InitializeTitlebar(7806463);
                    pnlTitle.BackColor = Color.FromArgb(255, 29, 119);
                    lblTitle.Text = "bKash";
                    this.Text = "Payment - bKash";
                    this.Icon = Properties.Resources.Icon_PinkBkash;
                    pbxPaymentIcon.Image = (Image)Properties.Resources.ResourceManager.GetObject("Icon_bKash");
                    pnlContent.Controls.Add(bKashUI);
                    break;

                case "mastercard":
                    InitializeTitlebar(6908265);
                    pnlTitle.BackColor = Color.FromArgb(105, 105, 105);
                    lblTitle.Text = "mastercard";
                    this.Text = "Payment - Mastercard";
                    this.Icon = Properties.Resources.Icon_GrayMastercard;
                    pbxPaymentIcon.Image = (Image)Properties.Resources.ResourceManager.GetObject("Icon_Mastercard");
                    pnlContent.Controls.Add(cardUI);
                    break;

                case "visa":
                    InitializeTitlebar(16777215);
                    lblTitle.Text = "visa";
                    this.Text = "Payment - Visa";
                    this.Icon = Properties.Resources.icon_WhiteVisa;
                    lbl.ForeColor = Color.FromArgb(0, 30, 78);
                    lblTitle.ForeColor = Color.FromArgb(0, 30, 78);
                    pnlTitle.BackColor = Color.FromArgb(255, 255, 255);
                    pbxPaymentIcon.Image = (Image)Properties.Resources.ResourceManager.GetObject("Icon_Visa");
                    pnlContent.Controls.Add(cardUI);
                    break;

                default:
                    InitializeTitlebar(2173693);
                    lblTitle.Text = "error";
                    this.Text = "Error";
                    pnlTitle.BackColor = Color.FromArgb(253, 42, 33);
                    MessageBox.Show("Wrong Payment Method selected.");
                    break;
            }

        }
        private void InitializeTitlebar(int color)
        {
            base.TitlebarColorInt = color;
            base.BorderColorInt = color;
            base.WindowCorner = 3;
        }

        public bool paymentSuccess;

        
        private void btnPayment_Click(object sender, EventArgs e)
        {
            paymentSuccess = true;
            this.Hide();
        }

        public bool RetrivePaymentSuccess()
        {
            return paymentSuccess;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
        }

    }
}
