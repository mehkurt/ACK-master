using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class Settings
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int EventId { get; set; }
    }
}
