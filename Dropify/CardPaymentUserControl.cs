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
    public partial class CardPaymentUserControl : UserControl
    {
        public CardPaymentUserControl(string cardName, string currency, decimal amount)
        {
            InitializeComponent();
            string selectedMethod = cardName.ToLower();
            lblCurrency.Text = currency;
            lblAmount.Text = amount.ToString();

            switch (selectedMethod)
            {
                case "amex":
                    SetColors(1, 111, 208);
                    
                    break;


                case "mastercard":
                    SetColors(105, 105, 105);

                    break;


                case "visa":
                    SetColors(0, 0, 0);
                    break;


                default:
                   
                    break;
            }
        }

        internal void SetColors(int R, int G, int B)
        {
            lblSubtitle.ForeColor = Color.FromArgb(R, G, B);
            lblCurrency.ForeColor = Color.FromArgb(R, G, B);
            lblAmount.ForeColor = Color.FromArgb(R, G, B);
        }
    }
}
