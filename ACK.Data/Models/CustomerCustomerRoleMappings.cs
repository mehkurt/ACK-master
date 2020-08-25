using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class CustomerCustomerRoleMappings
    {
        public int CustomerId { get; set; }
        public int CustomerRoleId { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual CustomerRoles CustomerRole { get; set; }
    }
}
