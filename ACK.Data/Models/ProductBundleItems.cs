using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class ProductBundleItems
    {
        public ProductBundleItems()
        {
            ShoppingCartItems = new HashSet<ShoppingCartItems>();
        }

        public int Id { get; set; }
        public int ProductId { get; set; }
        public int BundleProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? Discount { get; set; }
        public bool DiscountPercentage { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public bool FilterAttributes { get; set; }
        public bool HideThumbnail { get; set; }
        public bool Visible { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }

        public virtual Products BundleProduct { get; set; }
        public virtual Products Product { get; set; }
        public virtual ICollection<ShoppingCartItems> ShoppingCartItems { get; set; }
    }
}
