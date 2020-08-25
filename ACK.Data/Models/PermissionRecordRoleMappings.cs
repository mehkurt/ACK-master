using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class PermissionRecordRoleMappings
    {
        public int PermissionRecordId { get; set; }
        public int CustomerRoleId { get; set; }

        public virtual CustomerRoles CustomerRole { get; set; }
        public virtual PermissionRecords PermissionRecord { get; set; }
    }
}
