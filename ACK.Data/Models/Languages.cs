using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class Languages
    {
        public Languages()
        {
            LocaleStringResources = new HashSet<LocaleStringResources>();
            LocalizedProperties = new HashSet<LocalizedProperties>();
            News = new HashSet<News>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LanguageCulture { get; set; }
        public string UniqueSeoCode { get; set; }
        public string FlagImageFileName { get; set; }
        public bool Rtl { get; set; }
        public bool LimitedToStores { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ICollection<LocaleStringResources> LocaleStringResources { get; set; }
        public virtual ICollection<LocalizedProperties> LocalizedProperties { get; set; }
        public virtual ICollection<News> News { get; set; }
    }
}
