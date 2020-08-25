using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class PermissionRecords
    {
        public PermissionRecords()
        {
            PermissionRecordRoleMappings = new HashSet<PermissionRecordRoleMappings>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SystemName { get; set; }
        public string Category { get; set; }

        public virtual ICollection<PermissionRecordRoleMappings> PermissionRecordRoleMappings { get; set; }
    }
}
