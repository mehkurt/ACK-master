using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class ShipmentItems
    {
        public int Id { get; set; }
        public int ShipmentId { get; set; }
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }

        public virtual Shipments Shipment { get; set; }
    }
}
