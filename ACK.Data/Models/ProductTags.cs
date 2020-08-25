using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class ProductTags
    {
        public ProductTags()
        {
            ProductTagMappings = new HashSet<ProductTagMappings>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProductTagMappings> ProductTagMappings { get; set; }
    }
}
