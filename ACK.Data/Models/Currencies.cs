using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class Currencies
    {
        public Currencies()
        {
            EventsPrimaryCurrency = new HashSet<Events>();
            EventsPrimaryExchangeRateCurrency = new HashSet<Events>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Rate { get; set; }
        public string DisplayLocale { get; set; }
        public string CustomFormatting { get; set; }
        public bool LimitedToStores { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public string DomainEndings { get; set; }
        public bool RoundOrderItemsEnabled { get; set; }
        public int RoundNumDecimals { get; set; }
        public bool RoundOrderTotalEnabled { get; set; }
        public decimal RoundOrderTotalDenominator { get; set; }
        public int RoundOrderTotalRule { get; set; }

        public virtual ICollection<Events> EventsPrimaryCurrency { get; set; }
        public virtual ICollection<Events> EventsPrimaryExchangeRateCurrency { get; set; }
    }
}
