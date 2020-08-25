using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class ProductReviews
    {
        public ProductReviews()
        {
            ProductReviewHelpfulness = new HashSet<ProductReviewHelpfulness>();
        }

        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }
        public int HelpfulYesTotal { get; set; }
        public int HelpfulNoTotal { get; set; }

        public virtual CustomerContents IdNavigation { get; set; }
        public virtual Products Product { get; set; }
        public virtual ICollection<ProductReviewHelpfulness> ProductReviewHelpfulness { get; set; }
    }
}
