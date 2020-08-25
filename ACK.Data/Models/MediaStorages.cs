using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class MediaStorages
    {
        public MediaStorages()
        {
            Pictures = new HashSet<Pictures>();
        }

        public int Id { get; set; }
        public byte[] Data { get; set; }

        public virtual ICollection<Pictures> Pictures { get; set; }
    }
}
