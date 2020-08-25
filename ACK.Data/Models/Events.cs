using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class Events
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public bool SslEnabled { get; set; }
        public string SecureUrl { get; set; }
        public string Hosts { get; set; }
        public int LogoPictureId { get; set; }
        public int DisplayOrder { get; set; }
        public string HtmlBodyId { get; set; }
        public string ContentDeliveryNetwork { get; set; }
        public int PrimaryCurrencyId { get; set; }
        public int PrimaryExchangeRateCurrencyId { get; set; }
        public bool ForceSslForAllPages { get; set; }

        public virtual Currencies PrimaryCurrency { get; set; }
        public virtual Currencies PrimaryExchangeRateCurrency { get; set; }
    }
}
