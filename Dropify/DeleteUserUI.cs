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
    public partial class DeleteUserUI : BaseForm
    {
        public User user = new User(); 
        private int countdownSeconds = 10;
        public DeleteUserUI(User user)
        {
            InitializeComponent();
            InitializeTitlebar();
            this.user = user;
        }

        private void InitializeTitlebar()
        {
            base.TitlebarColorInt = 2754790;
            base.BorderColorInt = 2754790;
            base.WindowCorner = 1; 
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            btnConfirm.Enabled = false;
            tCountdown.Start();

            lblCountdown.Text = $"Your account will be deleted in {countdownSeconds} seconds. Press cancel to go back.";


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tCountdown.Stop();
            lblCountdown.Text = "Account deletion cancelled.";
            MessageBox.Show("Account deletion cancelled.");
            this.Hide();
        }

        private void tCountdown_Tick(object sender, EventArgs e)
        {
            countdownSeconds--;

            if (countdownSeconds > 0)
            {
                lblCountdown.Text = $"Your account will be deleted in {countdownSeconds} seconds. Press cancel to go back.";
            }
            else
            {
                lblCountdown.Text = "Deleting your account...";

                
                btnCancel.Enabled = false;

                if(countdownSeconds == -3)
                {
                    tCountdown.Stop();
                    if (user.DeleteUser(user))
                    {
                        lblCountdown.Text = "Your account has been deleted.";
                    }
                    else
                    {
                        lblCountdown.Text = "Could not delete your account. Contact with administrator.";
                    }
                }
                

            }
        }
    }
}
