using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class SpecificationAttributeOptions
    {
        public SpecificationAttributeOptions()
        {
            ProductSpecificationAttributeMappings = new HashSet<ProductSpecificationAttributeMappings>();
        }

        public int Id { get; set; }
        public int SpecificationAttributeId { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public string Alias { get; set; }
        public decimal NumberValue { get; set; }

        public virtual SpecificationAttributes SpecificationAttribute { get; set; }
        public virtual ICollection<ProductSpecificationAttributeMappings> ProductSpecificationAttributeMappings { get; set; }
    }
}
