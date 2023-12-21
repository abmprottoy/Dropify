using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dropify
{
    public partial class Form1 : BaseForm
    {
        private Random random = new Random();
        private string connectionString = Properties.Settings.Default.ConnectionString;

        private string status = "Connecting...";

        public Form1()
        {
            InitializeComponent();
            base.TitlebarColorInt = 5119488;
            base.BorderColorInt = 5119488;
            base.WindowCorner = 3;

            LoadRandomImage();

        }






        private void LoadRandomImage()
        {
            int randomImageIndex = random.Next(1, 10);
            string imageName = "HeroImage" + randomImageIndex.ToString();

            pictureBox1.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(imageName);
        }

        private void btnPassToggle_Click(object sender, EventArgs e)
        {
            TogglePasswordReveal();
        }
        private void TogglePasswordReveal()
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

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Upon loading the form it should try to establish connection with database
        /// asynchronously so that this loading does not block UI Thread. await keeps
        /// a promise to retun the async task when done.
        /// </summary>
        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Asynchronously execute the database operation
                status = await GetServerStatus();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                status = "No response";
            }

            // Update the UI with the result
            UpdateStatus();
        }

        /// <summary>
        /// Asynchronus Task with a return type of string. This Task will return
        /// it has value or no value from the database without blocking the main
        /// form from running.
        /// </summary>
        /// <returns></returns>
        private async Task<string> GetServerStatus()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand($"SELECT Properties FROM System WHERE Item = 'ServerStatus'", connection))
                {
                    object result = await command.ExecuteScalarAsync();
                    return result?.ToString() ?? "No status available";
                    //Is the result null? If not do the ToString. ?? Null-collasing operator
                    //If the left side is actually null then return the string on the right.
                }
            }
        }

        /// <summary>
        /// Updates the StatusStrip Status Label
        /// </summary>
        private void UpdateStatus()
        {
            lblStatus.Text = status;
        }
    }
}
