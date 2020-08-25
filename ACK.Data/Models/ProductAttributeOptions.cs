using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class ProductAttributeOptions
    {
        public int Id { get; set; }
        public int ProductAttributeOptionsSetId { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
        public int PictureId { get; set; }
        public string Color { get; set; }
        public decimal PriceAdjustment { get; set; }
        public decimal WeightAdjustment { get; set; }
        public bool IsPreSelected { get; set; }
        public int DisplayOrder { get; set; }
        public int ValueTypeId { get; set; }
        public int LinkedProductId { get; set; }
        public int Quantity { get; set; }

        public virtual ProductAttributeOptionsSets ProductAttributeOptionsSet { get; set; }
    }
}
