using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class RewardPointsHistories
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int Points { get; set; }
        public int PointsBalance { get; set; }
        public decimal UsedAmount { get; set; }
        public string Message { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public int? UsedWithOrderId { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Orders UsedWithOrder { get; set; }
    }
}
