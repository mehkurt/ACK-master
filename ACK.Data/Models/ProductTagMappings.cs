using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class ProductTagMappings
    {
        public int ProductId { get; set; }
        public int ProductTagId { get; set; }

        public virtual Products Product { get; set; }
        public virtual ProductTags ProductTag { get; set; }
    }
}
