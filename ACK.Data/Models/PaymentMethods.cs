using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class PaymentMethods
    {
        public int Id { get; set; }
        public string PaymentMethodSystemName { get; set; }
        public string FullDescription { get; set; }
        public bool RoundOrderTotalEnabled { get; set; }
        public bool LimitedToStores { get; set; }
    }
}
