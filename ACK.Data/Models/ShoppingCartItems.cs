using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class ShoppingCartItems
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int? ParentItemId { get; set; }
        public int? BundleItemId { get; set; }
        public int ShoppingCartTypeId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public string AttributesXml { get; set; }
        public decimal CustomerEnteredPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }

        public virtual ProductBundleItems BundleItem { get; set; }
        public virtual Customers Customer { get; set; }
        public virtual Products Product { get; set; }
    }
}
