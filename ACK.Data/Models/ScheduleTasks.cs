using System;
using System.Collections.Generic;

namespace ACK.Data.Models
{
    public partial class ScheduleTasks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Enabled { get; set; }
        public bool StopOnError { get; set; }
        public DateTime? LastStartUtc { get; set; }
        public DateTime? LastEndUtc { get; set; }
        public DateTime? LastSuccessUtc { get; set; }
        public string LastError { get; set; }
        public string Alias { get; set; }
        public DateTime? NextRunUtc { get; set; }
        public bool IsHidden { get; set; }
        public int? ProgressPercent { get; set; }
        public string ProgressMessage { get; set; }
        public string CronExpression { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
