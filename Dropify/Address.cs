using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dropify
{
    public class Address
    {
        public Guid AddressID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string AddressDetails { get; set; }
        public string Zip { get; set; }
        public string Landmark { get; set; }
        public string Office { get; set; }

        string AddressString = String.Empty;
        public override string ToString()
        {
            AppendToAddressString("Country", Country);
            AppendToAddressString("City", City);
            AppendToAddressString("Area", Area);
            AppendToAddressString("Address Details", AddressDetails);
            AppendToAddressString("Zip", Zip);
            AppendToAddressString("Landmark", Landmark);
            AppendToAddressString("Office", Office);

            return AddressString;
        }

        private void AppendToAddressString(string label, string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                if (!string.IsNullOrEmpty(AddressString))
                {
                    AddressString += " ";
                }

                AddressString += $"{label} : {value}";
            }
        }

    }
}
