using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class LocalizedProperties
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public int LanguageId { get; set; }
        public string LocaleKeyGroup { get; set; }
        public string LocaleKey { get; set; }
        public string LocaleValue { get; set; }

        public virtual Languages Language { get; set; }
    }
}
