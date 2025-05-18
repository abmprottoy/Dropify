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
    public partial class SystemInformationUI : UserControl
    {
        SystemInformationUserControl systemInformation = new SystemInformationUserControl();
        SystemMaintenenceUserControl systemMaintenence = new SystemMaintenenceUserControl();
        public SystemInformationUI()
        {
            InitializeComponent();
        }

        private void modernListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(modernListBox1.SelectedIndex == 0)
            {
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(systemInformation);
                systemInformation.Dock = DockStyle.Fill;
            }else if(modernListBox1.SelectedIndex == 1)
            {
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(systemMaintenence);
                systemMaintenence.Dock = DockStyle.Fill;
            }
        }
    }
}
