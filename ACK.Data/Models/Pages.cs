using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class Pages
    {
        public int Id { get; set; }
        public string SystemName { get; set; }
        public bool IncludeInSitemap { get; set; }
        public bool IsPasswordProtected { get; set; }
        public string Password { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public bool LimitedToStores { get; set; }
        public bool RenderAsWidget { get; set; }
        public string WidgetZone { get; set; }
        public bool WidgetShowTitle { get; set; }
        public bool WidgetBordered { get; set; }
        public int Priority { get; set; }
        public bool? WidgetWrapContent { get; set; }
        public string TitleTag { get; set; }
        public bool IsSystemTopic { get; set; }
    }
}
