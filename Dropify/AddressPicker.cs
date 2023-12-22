using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Dropify
{
    public partial class AddressPicker : BaseForm
    {
        public Address address = new Address();
        public bool OfficePicker;
        private bool SimplePicker;
        Label lblOffice = new Label();
        ComboBox cbxOffice = new ComboBox();

        public static Dictionary<string, List<string>> CountryCities = new Dictionary<string, List<string>>
        {
            {"Australia", new List<string> {"Sydney", "Melbourne", "Brisbane", "Perth", "Adelaide"}},
            {"Bangladesh", new List<string> {"Dhaka", "Chittagong", "Khulna", "Barisal", "Mymensingh", "Rajshahi", "Rangpur", "Sylhet"}},
            {"Canada", new List<string> {"Toronto", "Vancouver", "Montreal", "Calgary", "Ottawa"}},
            {"Germany", new List<string> {"Berlin", "Munich", "Hamburg", "Frankfurt", "Cologne"}},
            {"United States", new List<string> {"New York City", "Los Angeles", "Chicago", "Houston", "Miami"}}
        };

        /// <summary>
        /// Basic AddressPicker where everything is user selectable.
        /// </summary>
        /// <param name="title"></param>
        public AddressPicker(string title)
        {
            InitializeComponent();
            InitializeTitle(title);
            SimplePicker = true;

            cbxCountry.Items.Clear();
            cbxCountry.Items.AddRange(CountryCities.Keys.ToArray());
            cbxCountry.SelectedIndex = 0;
        }

        /// <summary>
        /// Shows an Office Address Picker where only Office is selectable
        /// </summary>
        /// <param name="title">Sets title for the AddressPicker</param>
        /// <param name="officePicker">Whether the AdressPicker is OfficePicker Kind</param>
        public AddressPicker(string title, bool officePicker)
        {
            InitializeComponent();
            InitializeTitle(title);
            OfficePicker = officePicker;
            pnlContent.Controls.Clear();

            #region Dynamic Office Picker
            // 
            // lblOffice
            // 
            this.lblOffice.AutoSize = true;
            this.lblOffice.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblOffice.ForeColor = System.Drawing.Color.Gray;
            this.lblOffice.Location = new System.Drawing.Point(22, 29);
            this.lblOffice.Name = "lblOffice";
            this.lblOffice.Size = new System.Drawing.Size(51, 21);

            this.lblOffice.Text = "Office";
            this.pnlContent.Controls.Add(lblOffice);

            // 
            // cbxOffice
            // 
            this.cbxOffice = new System.Windows.Forms.ComboBox();
            this.cbxOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOffice.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.cbxOffice.FormattingEnabled = true;
            this.cbxOffice.Items.AddRange(new object[] {
            "New York City", "Los Angeles", "Chicago", "Houston", "Miami", "Toronto", "Vancouver", "Montreal", "Calgary", "Ottawa",
            "Berlin", "Munich", "Hamburg", "Frankfurt", "Cologne", "Sydney", "Melbourne", "Brisbane", "Perth", "Adelaide",
            "Dhaka", "Chittagong", "Khulna", "Barisal", "Mymensingh", "Rajshahi", "Rangpur", "Sylhet"
            });
            this.cbxOffice.Location = new System.Drawing.Point(160, 27);
            this.cbxOffice.Name = "cbxOffice";
            this.cbxOffice.Size = new System.Drawing.Size(281, 28);
            this.cbxOffice.Sorted = false;
            this.cbxOffice.SelectedIndex = 0;
            this.cbxOffice.TabIndex = 1;
            this.pnlContent.Controls.Add(cbxOffice);

            // 
            // btnSave
            // 
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(366, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.pnlContent.Controls.Add(btnSave);
            #endregion Dynamic Office Picker
        }

        /// <summary>
        /// Shows an City selector when Country is already selected. Used for Courier
        /// delivery.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="countryIndex"></param>
        public AddressPicker(string title, int countryIndex)
        {
            InitializeComponent();
            InitializeTitle(title);

            cbxCountry.SelectedIndex = countryIndex;
            cbxCountry.Enabled = false;


            string selectedCountry = cbxCountry.SelectedItem as string;

            // Check if the selected country is in the dictionary
            if (CountryCities.ContainsKey(selectedCountry))
            {
                cbxCity.Items.Clear();
                // Populate the ID Types ComboBox with the selected country's ID types
                cbxCity.Items.AddRange(CountryCities[selectedCountry].ToArray());
                cbxCity.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Shows an Addess Details editor when Country and City is predefined. Used for
        /// Parcel delivery.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="countryIndex"></param>
        /// <param name="cityIndex"></param>
        public AddressPicker(string title, int countryIndex, int cityIndex)
        {
            InitializeComponent();
            InitializeTitle(title);

            cbxCountry.Items.Clear();
            cbxCountry.Items.AddRange(CountryCities.Keys.ToArray());
            cbxCountry.SelectedIndex = countryIndex;

            string selectedCountry = cbxCountry.SelectedItem as string;

            if (CountryCities.ContainsKey(selectedCountry))
            {
                cbxCity.Items.Clear();
                // Populate the ID Types ComboBox with the selected country's ID types
                cbxCity.Items.AddRange(CountryCities[selectedCountry].ToArray());
                cbxCity.SelectedIndex = cityIndex;
            }

            cbxCountry.Enabled = false;
            cbxCity.Enabled = false;
        }

        private void InitializeTitle(string title)
        {
            base.TitlebarColorInt = 6573312;
            base.BorderColorInt = 6573312;
            base.WindowCorner = 3;
            this.Text += $" - {title}";
            lblTitle.Text = title;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            if (OfficePicker)
            {
                address.Office = cbxOffice.SelectedItem.ToString();
            }
            else
            {
                address.Country = cbxCountry.SelectedItem.ToString();
                address.City = cbxCity.SelectedItem.ToString();
                address.Area = tbxArea.Text;
                address.Zip = tbxZip.Text;
                address.Landmark = tbxLandmark.Text;
            }

            this.Hide();
        }


        private void cbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SimplePicker)
            {
                string selectedCountry = cbxCountry.SelectedItem as string;

                // Check if the selected country is in the dictionary
                if (CountryCities.ContainsKey(selectedCountry))
                {
                    cbxCity.Items.Clear();
                    // Populate the ID Types ComboBox with the selected country's ID types
                    cbxCity.Items.AddRange(CountryCities[selectedCountry].ToArray());
                    cbxCity.SelectedIndex = 0;
                }
            }
        }
        public Address RetriveData()
        {
            return address;
        }
    }


}
