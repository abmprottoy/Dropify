using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dropify
{
    class Delivery
    {
        public Guid DeliveryID { get; set; }
        public string DeliveryType { get; set; }
        public string PackageDimension { get; set; }
        public int PackageWeightKg { get; set; }
        public string PackageContent { get; set; }
        public Guid Sender { get; set; }
        public string Receiver { get; set; }
        public string ReceiverName { get; set; }
        public Guid PickupAddress { get; set; }
        public Guid DestinationAddress { get; set; }
        public Guid TransactionID { get; set; }
        public string DeliveryPersonID { get; set; }
        public string DeliveryStatus { get; set; }
        public string ExpectedDelivery { get; set; }
        public DateTimeOffset DaliveryCompletedOn { get; set; }
        public Image DeliveryProof { get; set; }
        public string DeliveryNote { get; set; }
    }
}
