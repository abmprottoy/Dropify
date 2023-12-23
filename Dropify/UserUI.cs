using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dropify
{
    public partial class UserUI : BaseForm
    {
        public User user = new User();
        private string connectionString = Properties.Settings.Default.ConnectionString;


        public UserUI(Guid profileID)
        {
            InitializeComponent();
            InitializeTitlebar();

            user.GetUserInfo(user, profileID);
            lblFirstName.Text = user.FirstName;
            lblLastName.Text= user.LastName;

            InitializeTimezoneTimer();


        }


        private void InitializeTitlebar()
        {
            base.TitlebarColorInt = 5119488;
            base.BorderColorInt = 5119488;
            base.WindowCorner = 3;
            
        }
        private void InitializeTimezoneTimer()
        {
            tTimezoneTime.Start();
        }

        private void tTimezoneTime_Tick(object sender, EventArgs e)
        {
            lblTimezoneTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
