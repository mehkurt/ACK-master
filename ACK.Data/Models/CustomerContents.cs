using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class CustomerContents
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string IpAddress { get; set; }
        public bool IsApproved { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual NewsComments NewsComments { get; set; }
        public virtual ProductReviewHelpfulness ProductReviewHelpfulness { get; set; }
        public virtual ProductReviews ProductReviews { get; set; }
    }
}
