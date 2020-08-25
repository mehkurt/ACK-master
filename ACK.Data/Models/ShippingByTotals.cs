using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class ShippingByTotals
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int? CountryId { get; set; }
        public int? StateProvinceId { get; set; }
        public string Zip { get; set; }
        public int ShippingMethodId { get; set; }
        public decimal From { get; set; }
        public decimal? To { get; set; }
        public bool UsePercentage { get; set; }
        public decimal ShippingChargePercentage { get; set; }
        public decimal ShippingChargeAmount { get; set; }
        public decimal BaseCharge { get; set; }
        public decimal? MaxCharge { get; set; }
    }
}
