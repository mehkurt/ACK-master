using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class Logs
    {
        public int Id { get; set; }
        public int LogLevelId { get; set; }
        public string ShortMessage { get; set; }
        public string FullMessage { get; set; }
        public string IpAddress { get; set; }
        public int? CustomerId { get; set; }
        public string PageUrl { get; set; }
        public string ReferrerUrl { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string Logger { get; set; }
        public string HttpMethod { get; set; }
        public string UserName { get; set; }

        public virtual Customers Customer { get; set; }
    }
}
