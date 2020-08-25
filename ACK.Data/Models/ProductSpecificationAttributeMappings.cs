using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class ProductSpecificationAttributeMappings
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int SpecificationAttributeOptionId { get; set; }
        public bool? AllowFiltering { get; set; }
        public bool? ShowOnProductPage { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Products Product { get; set; }
        public virtual SpecificationAttributeOptions SpecificationAttributeOption { get; set; }
    }
}
