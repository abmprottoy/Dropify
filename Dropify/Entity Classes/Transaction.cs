using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dropify
{
    public class Transaction
    {
        public Guid TransactionID { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public DateTimeOffset TransactionTime { get; set; }
    }
}