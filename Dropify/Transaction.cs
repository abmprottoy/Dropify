using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dropify
{
    class Transaction
    {
        public Guid TansactionID { get; set; }
        public string PaymentMethod { get; set; }
        public double Amoount { get; set; }
        public string Currency { get; set; }
        public DateTimeOffset TransactionTime { get; set; }
    }
}
