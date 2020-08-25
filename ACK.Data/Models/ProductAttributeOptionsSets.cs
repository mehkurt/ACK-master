using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class ProductAttributeOptionsSets
    {
        public ProductAttributeOptionsSets()
        {
            ProductAttributeOptions = new HashSet<ProductAttributeOptions>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductAttributeId { get; set; }

        public virtual ProductAttributes ProductAttribute { get; set; }
        public virtual ICollection<ProductAttributeOptions> ProductAttributeOptions { get; set; }
    }
}
