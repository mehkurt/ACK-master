using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class CustomerAddresses
    {
        public int CustomerId { get; set; }
        public int AddressId { get; set; }

        public virtual Addresses Address { get; set; }
        public virtual Customers Customer { get; set; }
    }
}
