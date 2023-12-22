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
    public partial class AddressPicker : BaseForm
    {
        public AddressPicker(string title)
        {
            InitializeComponent();
            InitializeTitle(title);
            

            
        }


        public AddressPicker(string title, bool officePicker)
        {
            InitializeTitle(title);
        }

        public AddressPicker(string title, int countryIndex, int cityIndex)
        {
            InitializeTitle(title);
        }

        private void InitializeTitle(string title)
        {
            base.TitlebarColorInt = 6573312;
            base.BorderColorInt = 6573312;
            base.WindowCorner = 3;
            this.Text += $"- {title}";
            lblTitle.Text = title;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
        }


    }

    
}
