using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class Countries
    {
        public Countries()
        {
            Addresses = new HashSet<Addresses>();
            Products = new HashSet<Products>();
            StateProvinces = new HashSet<StateProvinces>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool AllowsBilling { get; set; }
        public bool AllowsShipping { get; set; }
        public string TwoLetterIsoCode { get; set; }
        public string ThreeLetterIsoCode { get; set; }
        public int NumericIsoCode { get; set; }
        public bool SubjectToVat { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }
        public bool LimitedToStores { get; set; }
        public string AddressFormat { get; set; }

        public virtual ICollection<Addresses> Addresses { get; set; }
        public virtual ICollection<Products> Products { get; set; }
        public virtual ICollection<StateProvinces> StateProvinces { get; set; }
    }
}
