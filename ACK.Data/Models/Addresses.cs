using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class Addresses
    {
        public Addresses()
        {
            CustomerAddresses = new HashSet<CustomerAddresses>();
            CustomersBillingAddress = new HashSet<Customers>();
            CustomersShippingAddress = new HashSet<Customers>();
            OrdersBillingAddress = new HashSet<Orders>();
            OrdersShippingAddress = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public int? CountryId { get; set; }
        public int? StateProvinceId { get; set; }
        public string City { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipPostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string Salutation { get; set; }
        public string Title { get; set; }

        public virtual Countries Country { get; set; }
        public virtual StateProvinces StateProvince { get; set; }
        public virtual ICollection<CustomerAddresses> CustomerAddresses { get; set; }
        public virtual ICollection<Customers> CustomersBillingAddress { get; set; }
        public virtual ICollection<Customers> CustomersShippingAddress { get; set; }
        public virtual ICollection<Orders> OrdersBillingAddress { get; set; }
        public virtual ICollection<Orders> OrdersShippingAddress { get; set; }
    }
}
