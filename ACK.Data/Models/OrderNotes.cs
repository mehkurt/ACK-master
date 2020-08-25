using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class OrderNotes
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Note { get; set; }
        public bool DisplayToCustomer { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual Orders Order { get; set; }
    }
}
