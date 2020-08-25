using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class LocaleStringResources
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string ResourceName { get; set; }
        public string ResourceValue { get; set; }
        public bool? IsFromPlugin { get; set; }
        public bool? IsTouched { get; set; }

        public virtual Languages Language { get; set; }
    }
}
