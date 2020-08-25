using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class Customers
    {
        public Customers()
        {
            CustomerAddresses = new HashSet<CustomerAddresses>();
            CustomerContents = new HashSet<CustomerContents>();
            CustomerCustomerRoleMappings = new HashSet<CustomerCustomerRoleMappings>();
            ExternalAuthenticationRecords = new HashSet<ExternalAuthenticationRecords>();
            Logs = new HashSet<Logs>();
            Orders = new HashSet<Orders>();
            RewardPointsHistories = new HashSet<RewardPointsHistories>();
            ShoppingCartItems = new HashSet<ShoppingCartItems>();
        }

        public int Id { get; set; }
        public Guid CustomerGuid { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PasswordFormatId { get; set; }
        public string PasswordSalt { get; set; }
        public string AdminComment { get; set; }
        public bool IsTaxExempt { get; set; }
        public int AffiliateId { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public bool IsSystemAccount { get; set; }
        public string SystemName { get; set; }
        public string LastIpAddress { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime? LastLoginDateUtc { get; set; }
        public DateTime LastActivityDateUtc { get; set; }
        public int? BillingAddressId { get; set; }
        public int? ShippingAddressId { get; set; }

        public virtual Addresses BillingAddress { get; set; }
        public virtual Addresses ShippingAddress { get; set; }
        public virtual ICollection<CustomerAddresses> CustomerAddresses { get; set; }
        public virtual ICollection<CustomerContents> CustomerContents { get; set; }
        public virtual ICollection<CustomerCustomerRoleMappings> CustomerCustomerRoleMappings { get; set; }
        public virtual ICollection<ExternalAuthenticationRecords> ExternalAuthenticationRecords { get; set; }
        public virtual ICollection<Logs> Logs { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<RewardPointsHistories> RewardPointsHistories { get; set; }
        public virtual ICollection<ShoppingCartItems> ShoppingCartItems { get; set; }
    }
}
