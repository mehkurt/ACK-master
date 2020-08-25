using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class StateProvinces
    {
        public StateProvinces()
        {
            Addresses = new HashSet<Addresses>();
        }

        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Countries Country { get; set; }
        public virtual ICollection<Addresses> Addresses { get; set; }
    }
}
