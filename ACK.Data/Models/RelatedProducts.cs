using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class RelatedProducts
    {
        public int Id { get; set; }
        public int ProductId1 { get; set; }
        public int ProductId2 { get; set; }
        public int DisplayOrder { get; set; }
    }
}
