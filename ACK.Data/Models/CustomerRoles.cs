using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class CustomerRoles
    {
        public CustomerRoles()
        {
            CustomerCustomerRoleMappings = new HashSet<CustomerCustomerRoleMappings>();
            PermissionRecordRoleMappings = new HashSet<PermissionRecordRoleMappings>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool FreeShipping { get; set; }
        public bool TaxExempt { get; set; }
        public int? TaxDisplayType { get; set; }
        public bool Active { get; set; }
        public bool IsSystemRole { get; set; }
        public string SystemName { get; set; }

        public virtual ICollection<CustomerCustomerRoleMappings> CustomerCustomerRoleMappings { get; set; }
        public virtual ICollection<PermissionRecordRoleMappings> PermissionRecordRoleMappings { get; set; }
    }
}
