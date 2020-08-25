using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class UrlRecords
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public string EntityName { get; set; }
        public string Slug { get; set; }
        public bool IsActive { get; set; }
        public int LanguageId { get; set; }
    }
}
