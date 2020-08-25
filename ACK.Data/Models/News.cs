using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class News
    {
        public News()
        {
            NewsComments = new HashSet<NewsComments>();
        }

        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string Short { get; set; }
        public string Full { get; set; }
        public bool Published { get; set; }
        public DateTime? StartDateUtc { get; set; }
        public DateTime? EndDateUtc { get; set; }
        public bool AllowComments { get; set; }
        public int ApprovedCommentCount { get; set; }
        public int NotApprovedCommentCount { get; set; }
        public bool LimitedToStores { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }

        public virtual Languages Language { get; set; }
        public virtual ICollection<NewsComments> NewsComments { get; set; }
    }
}
