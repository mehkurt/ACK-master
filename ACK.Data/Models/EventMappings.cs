using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class EventMappings
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public string EntityName { get; set; }
        public int EventId { get; set; }
    }
}
