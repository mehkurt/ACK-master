using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class ActivityLogTypes
    {
        public ActivityLogTypes()
        {
            ActivityLogs = new HashSet<ActivityLogs>();
        }

        public int Id { get; set; }
        public string SystemKeyword { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }

        public virtual ICollection<ActivityLogs> ActivityLogs { get; set; }
    }
}
