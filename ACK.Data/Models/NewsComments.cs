using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class NewsComments
    {
        public int Id { get; set; }
        public string CommentTitle { get; set; }
        public string CommentText { get; set; }
        public int NewsItemId { get; set; }

        public virtual CustomerContents IdNavigation { get; set; }
        public virtual News NewsItem { get; set; }
    }
}
