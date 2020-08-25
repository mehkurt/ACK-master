using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class ProductAttributeMappings
    {
        public ProductAttributeMappings()
        {
            ProductVariantAttributeValues = new HashSet<ProductVariantAttributeValues>();
        }

        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ProductAttributeId { get; set; }
        public string TextPrompt { get; set; }
        public bool IsRequired { get; set; }
        public int AttributeControlTypeId { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Products Product { get; set; }
        public virtual ProductAttributes ProductAttribute { get; set; }
        public virtual ICollection<ProductVariantAttributeValues> ProductVariantAttributeValues { get; set; }
    }
}
