using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class ActivityLogs
    {
        public int Id { get; set; }
        public int ActivityLogTypeId { get; set; }
        public int CustomerId { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual ActivityLogTypes ActivityLogType { get; set; }
    }
}
