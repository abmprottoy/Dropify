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
    public partial class DeliveryUI : BaseForm
    {
        public User sender;
        public Delivery delivery = new Delivery();

        public AddressPickerUI parcelPickupAddress;
        public AddressPickerUI parcelDestinationAddress;
        public AddressPickerUI courierPickupAddress;
        public AddressPickerUI courierDestinationAddress;

        public string timeZoneID;
        TimeZoneInfo timeZoneInfo;
        DateTime timeZoneDateTime;
        public string deliveryType;
        public string expectedText;


        public DeliveryUI(User deliverySender, string typeOfDelivery)
        {
            InitializeComponent();

            sender = deliverySender;
            deliveryType = typeOfDelivery;


            InitializeTitlebar();

            cbxContentLabel.SelectedIndex = 0;
            cbxCountryCode.SelectedIndex = 0;

            lblFirstName.Text = sender.FirstName;
            lblLastName.Text = sender.LastName;

            btnProfile.BackgroundImage = sender.ProfilePicture;

            lblCurrency.Text = sender.Currency;
            timeZoneID = sender.TimeZoneID;
            timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZoneID);

            DateTime dayStart = TimeZoneInfoProvider.GetCityTime(sender.address.City).AddDays(7);
            DateTime dayEnd = TimeZoneInfoProvider.GetCityTime(sender.address.City).AddDays(14);
            lblExpected.Text = $"Expect your delivery between {dayStart} to {dayEnd}.";
            expectedText = dayStart + " to " + dayEnd;

        }

        public int selectedCountryIndex;
        public int selectedCityIndex;

        private void btnSetPickupAddress_Click(object sender, EventArgs e)
        {
            if (deliveryType == "Parcel")
            {
                using (parcelPickupAddress = new AddressPickerUI("parcel pickup"))
                {
                    parcelPickupAddress.ShowDialog();
                    selectedCountryIndex = parcelPickupAddress.RetriveCountryIndex();
                    selectedCityIndex = parcelPickupAddress.RetriveCityIndex();
                    tbxPickupAddress.Text = parcelPickupAddress.address.ToString();
                    tbxDestinationAddress.Text = "None";
                }
                cbxCountryCode.SelectedIndex = selectedCountryIndex;
            }
            else if (deliveryType == "Courier")
            {
                using (courierPickupAddress = new AddressPickerUI("courier pickup", true))
                {
                    courierPickupAddress.ShowDialog();
                    // Handle courier pickup address, e.g., store it in a variable

                    tbxPickupAddress.Text = courierPickupAddress.address.ToString();
                }
            }
            CalculatePackageCost();
        }

        private void btnSetDestinationAddress_Click(object sender, EventArgs e)
        {
            if (deliveryType == "Parcel")
            {
                using (parcelDestinationAddress = new AddressPickerUI("parcel destination", selectedCountryIndex, selectedCityIndex))
                {
                    parcelDestinationAddress.ShowDialog();
                    tbxDestinationAddress.Text = parcelDestinationAddress.address.ToString();
                }
            }
            else if (deliveryType == "Courier")
            {
                using (courierDestinationAddress = new AddressPickerUI("courier destination", true))
                {
                    courierDestinationAddress.ShowDialog();
                    // Handle courier pickup address, e.g., store it in a variable

                    tbxDestinationAddress.Text = courierDestinationAddress.address.ToString();
                }
            }
            CalculatePackageCost();
        }

        private void InitializeTitlebar()
        {
            base.TitlebarColorInt = 5119488;
            base.BorderColorInt = 5119488;
            base.WindowCorner = 3;
            lblTitle.Text = deliveryType.ToLower();
        }



        private void mtbxPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbxPhone_KeyDown(object sender, KeyEventArgs e)
        {

        }



        private void trbWeight_Scroll(object sender, EventArgs e)
        {
            numWeight.Value = trbWeight.Value;
            CalculatePackageCost();
        }

        private void numWeight_ValueChanged(object sender, EventArgs e)
        {
            trbWeight.Value = (int)numWeight.Value;
            CalculatePackageCost();
        }

        private void btnSetAddress_Click(object sender, EventArgs e)
        {

        }

        private void tbxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxAddress_MouseHover(object sender, EventArgs e)
        {

        }

        private void DeliveryUI_Load(object send, EventArgs e)
        {
            if (deliveryType == "Parcel")
            {
                pbxPackageIcon.Image = Properties.Resources.Parcel_Icon;
            }
            else if (deliveryType == "Courier")
            {
                pbxPackageIcon.Image = Properties.Resources.Courier_Icon;
            }

            string[] forBangladesh = { "bKash", "Mastercard", "Visa", "Amex" };
            string[] forOthers = { "Mastercard", "Visa", "Amex" };

            if (sender.Currency == "BDT")
            {
                cbxPayment.Items.AddRange(forBangladesh);
                cbxPayment.SelectedIndex = 0;
            }
            else
            {
                cbxPayment.Items.AddRange(forOthers);
                cbxPayment.SelectedIndex = 0;
            }

            

        }

        private void cbxContentLabel_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedValue = cbxContentLabel.SelectedItem.ToString();

            if (selectedValue == "Handle With Care")
            {
                pbxContentLabelIcon.Image = Properties.Resources.HandleWithCareIcon;
            }
            else if (selectedValue == "Fragile")
            {
                pbxContentLabelIcon.Image = Properties.Resources.FragileIcon;
            }
            else if (selectedValue == "Flammable")
            {
                pbxContentLabelIcon.Image = Properties.Resources.FlammableIcon;
            }
            else
            {
                pbxContentLabelIcon.Image = null;
            }
        }

        public decimal paymentUICost;
        private void CalculatePackageCost()
        {
            string pickupCity = string.Empty;
            string destinationCity = string.Empty;
            string currency = sender.Currency;

            if (deliveryType == "Parcel")
            {
                if (parcelPickupAddress != null && parcelPickupAddress.address != null)
                {
                    pickupCity = parcelPickupAddress.address.City;
                }

                if (parcelDestinationAddress != null && parcelDestinationAddress.address != null)
                {
                    destinationCity = parcelDestinationAddress.address.City;
                }
            }
            else if (deliveryType == "Courier")
            {
                if (courierPickupAddress != null && courierPickupAddress.address != null)
                {
                    pickupCity = courierPickupAddress.address.Office;
                }

                if (courierDestinationAddress != null && courierDestinationAddress.address != null)
                {
                    destinationCity = courierDestinationAddress.address.Office;
                }
            }


            decimal baseCost = CostProvider.GetBaseCost(pickupCity, destinationCity);

            decimal totalCost = CostProvider.GetTotalCost(baseCost, numWeight.Value);

            decimal localCost = Math.Round(CostProvider.GetLocalCurrencyCost(totalCost, currency), 2);

            paymentUICost = localCost;

            string cost = currency + " " + localCost;

            lblAmount.Text = cost;
        }

        private void UpdateEstimatedTime()
        {

        }

        private void btnBack_Click(object send, EventArgs e)
        {
            UserUI userUI = new UserUI(sender.ProfileID);
            userUI.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            cbxAccount.DroppedDown = true;
        }

        private void cbxAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logout();
        }


        private void Logout()
        {
            SecurityLog.Add(sender.ProfileID, "Logout");
            SigninUI signinUI = new SigninUI();
            signinUI.Show();
            this.Hide();
        }

        public bool CheckAllValues()
        {
            if (numDimW.Value == 0 && numDimH.Value == 0 && numDimL.Value == 0)
            {
                return false;
            }
            if (numWeight.Value == 0)
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbxContentLabel.Text))
            {
                return false;
            }
            if (String.IsNullOrWhiteSpace(tbxPickupAddress.Text) || tbxPickupAddress.Text.Equals("None"))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbxDestinationAddress.Text) || tbxDestinationAddress.Text.Equals("None"))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(mtbxPhone.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbxFirstName.Text))
            {
                return false;
            }
            return true;

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (CheckAllValues())
            {
                PaymentRouter(cbxPayment.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please provide all details.", "Incomplete details");
            }
        }

        private void PaymentRouter(string vendor)
        {
            using(PaymentUI paymentUI = new PaymentUI(vendor, sender.Currency, paymentUICost))
            {
                paymentUI.ShowDialog();

                bool paymentSuccess = paymentUI.RetrivePaymentSuccess();

                if (paymentSuccess)
                {
                    CreateDeliveryRequest();
                    paymentUI.Hide();
                }
            }
        }

        private void tTimezoneTime_Tick(object sender, EventArgs e)
        {
            timeZoneDateTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);
            lblTimezoneTime.Text = timeZoneDateTime.ToString("hh:mm:ss tt");
        }

        public void CreateDeliveryRequest()
        {
            delivery.DeliveryID = Guid.NewGuid();
            delivery.DeliveryType = deliveryType;
            delivery.PackageDimension = numDimW.Value.ToString() + " ✕ " + numDimH.Value.ToString() + " ✕ " + numDimL.Value.ToString();
            delivery.PackageWeightKg = numWeight.Value;
            delivery.PackageContent = cbxContentLabel.Text;
            delivery.Sender = sender.ProfileID;
            delivery.Receiver = mtbxPhone.Text;
            delivery.ReceiverName = tbxFirstName.Text;
            if (deliveryType == "Parcel")
            {
                delivery.PickupAddress = new Address
                {
                    AddressID = Guid.NewGuid(),
                    Country = parcelPickupAddress.address.Country,
                    City = parcelPickupAddress.address.City,
                    Area = parcelPickupAddress.address.Area,
                    Zip = parcelPickupAddress.address.Zip,
                    Landmark = parcelPickupAddress.address.Landmark
                };

                delivery.DestinationAddress = new Address
                {
                    AddressID = Guid.NewGuid(),
                    Country = parcelDestinationAddress.address.Country,
                    City = parcelDestinationAddress.address.City,
                    Area = parcelDestinationAddress.address.Area,
                    Zip = parcelDestinationAddress.address.Zip,
                    Landmark = parcelDestinationAddress.address.Landmark
                };
            }
            else if (deliveryType == "Courier")
            {
                delivery.PickupAddress = new Address
                {
                    AddressID = Guid.NewGuid(),
                    Office = courierDestinationAddress.address.Office
                };


                delivery.DestinationAddress = new Address
                {
                    AddressID = Guid.NewGuid(),
                    Office = courierDestinationAddress.address.Office
                };
            }
            delivery.TransactionID = new Transaction
            {
                TransactionID = Guid.NewGuid(),
                PaymentMethod = cbxPayment.Text,
                Amount = paymentUICost,
                Currency = sender.Currency,
                TransactionTime = DateTimeOffset.UtcNow
            };
            delivery.DeliveryStatus = "Order Placed";
            delivery.ExpectedDelivery = expectedText;
            delivery.DeliveryNote = tbxDeliveryInstructions.Text;

            if (delivery.PlaceDeliveryOrder(delivery))
            {
                UserUI userUI = new UserUI(sender.ProfileID);
                this.Hide();
                userUI.Show();
            }
        }
    }
}
