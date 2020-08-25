using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class ProductReviewHelpfulness
    {
        public int Id { get; set; }
        public int ProductReviewId { get; set; }
        public bool WasHelpful { get; set; }

        public virtual CustomerContents IdNavigation { get; set; }
        public virtual ProductReviews ProductReview { get; set; }
    }
}
