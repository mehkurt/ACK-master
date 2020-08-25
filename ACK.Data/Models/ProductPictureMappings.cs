using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class ProductPictureMappings
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int PictureId { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Pictures Picture { get; set; }
        public virtual Products Product { get; set; }
    }
}
