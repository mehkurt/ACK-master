using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class ProductVariantAttributeCombinations
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string Gtin { get; set; }
        public string ManufacturerPartNumber { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? BasePriceAmount { get; set; }
        public int? BasePriceBaseAmount { get; set; }
        public string AssignedPictureIds { get; set; }
        public int? DeliveryTimeId { get; set; }
        public bool IsActive { get; set; }
        public int ProductId { get; set; }
        public string AttributesXml { get; set; }
        public int StockQuantity { get; set; }
        public bool AllowOutOfStockOrders { get; set; }
        public decimal? Price { get; set; }
        public int? QuantityUnitId { get; set; }

        public virtual DeliveryTimes DeliveryTime { get; set; }
        public virtual Products Product { get; set; }
        public virtual QuantityUnits QuantityUnit { get; set; }
    }
}
