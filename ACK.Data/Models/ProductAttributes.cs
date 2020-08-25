using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class ProductAttributes
    {
        public ProductAttributes()
        {
            ProductAttributeMappings = new HashSet<ProductAttributeMappings>();
            ProductAttributeOptionsSets = new HashSet<ProductAttributeOptionsSets>();
        }

        public int Id { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? AllowFiltering { get; set; }
        public int DisplayOrder { get; set; }
        public int FacetTemplateHint { get; set; }
        public bool IndexOptionNames { get; set; }
        public string ExportMappings { get; set; }

        public virtual ICollection<ProductAttributeMappings> ProductAttributeMappings { get; set; }
        public virtual ICollection<ProductAttributeOptionsSets> ProductAttributeOptionsSets { get; set; }
    }
}
