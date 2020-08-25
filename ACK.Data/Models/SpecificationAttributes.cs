using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class SpecificationAttributes
    {
        public SpecificationAttributes()
        {
            SpecificationAttributeOptions = new HashSet<SpecificationAttributeOptions>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public string Alias { get; set; }
        public int FacetSorting { get; set; }
        public int FacetTemplateHint { get; set; }
        public bool ShowOnProductPage { get; set; }
        public bool AllowFiltering { get; set; }
        public bool IndexOptionNames { get; set; }

        public virtual ICollection<SpecificationAttributeOptions> SpecificationAttributeOptions { get; set; }
    }
}
