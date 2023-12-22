using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dropify
{
    class User
    {
        public Guid ProfileID { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string  CountryCOde { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public string  ProfileStatus { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string  Gender { get; set; }
        public string  GovtIDType { get; set; }
        public string GovtID { get; set; }

    }
}
