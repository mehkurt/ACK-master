using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class ProductManufacturerMappings
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ManufacturerId { get; set; }
        public bool IsFeaturedProduct { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Manufacturers Manufacturer { get; set; }
        public virtual Products Product { get; set; }
    }
}
