using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class Shipments
    {
        public Shipments()
        {
            ShipmentItems = new HashSet<ShipmentItems>();
        }

        public int Id { get; set; }
        public int OrderId { get; set; }
        public string TrackingNumber { get; set; }
        public decimal? TotalWeight { get; set; }
        public DateTime? ShippedDateUtc { get; set; }
        public DateTime? DeliveryDateUtc { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual Orders Order { get; set; }
        public virtual ICollection<ShipmentItems> ShipmentItems { get; set; }
    }
}
