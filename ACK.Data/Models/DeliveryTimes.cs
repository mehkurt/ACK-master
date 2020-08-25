﻿using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class DeliveryTimes
    {
        public DeliveryTimes()
        {
            ProductVariantAttributeCombinations = new HashSet<ProductVariantAttributeCombinations>();
            Products = new HashSet<Products>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ColorHexValue { get; set; }
        public string DisplayLocale { get; set; }
        public int DisplayOrder { get; set; }
        public bool? IsDefault { get; set; }

        public virtual ICollection<ProductVariantAttributeCombinations> ProductVariantAttributeCombinations { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}
