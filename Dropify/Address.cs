using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dropify
{
    class Address
    {
        public Guid AddressID { get; set; }
        public string Country { get; set; }
        public string City  { get; set; }
        public string Area { get; set; }
        public string AddressDetails { get; set; }
        public string Zip { get; set; }
        public string Landmark { get; set; }
        public string Office { get; set; }
    
        public override string ToString()
        {
            string AddressString = String.Empty;
            
            AddressString = "Country :" + Country?.ToString() ?? String.Empty;
            AddressString += "City :" + City?.ToString() ?? String.Empty;
            AddressString += "Area :" + Area?.ToString() ?? String.Empty;
            AddressString += "Address Details :" + AddressDetails?.ToString() ?? String.Empty;
            AddressString += "Zip :" + Zip?.ToString() ?? String.Empty;
            AddressString += "Landmark :" + Landmark?.ToString() ?? String.Empty;
            AddressString += "Office :" + Office?.ToString() ?? String.Empty;

            return AddressString;
        }
    }
}
