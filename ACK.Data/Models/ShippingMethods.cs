using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class ShippingMethods
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool IgnoreCharges { get; set; }
        public bool LimitedToStores { get; set; }
    }
}
