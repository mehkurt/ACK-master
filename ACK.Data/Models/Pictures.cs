using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class Pictures
    {
        public Pictures()
        {
            Categories = new HashSet<Categories>();
            Manufacturers = new HashSet<Manufacturers>();
            ProductPictureMappings = new HashSet<ProductPictureMappings>();
        }

        public int Id { get; set; }
        public byte[] PictureBinary { get; set; }
        public string MimeType { get; set; }
        public string SeoFilename { get; set; }
        public bool IsNew { get; set; }
        public bool IsTransient { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public int? MediaStorageId { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }

        public virtual MediaStorages MediaStorage { get; set; }
        public virtual ICollection<Categories> Categories { get; set; }
        public virtual ICollection<Manufacturers> Manufacturers { get; set; }
        public virtual ICollection<ProductPictureMappings> ProductPictureMappings { get; set; }
    }
}
