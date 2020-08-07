using System;
using System.Collections.Generic;

namespace CoreFirst.Models
{
    public partial class EventDetStamp
    {
        public int StampId { get; set; }
        public int EventDetId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string StampIconName { get; set; }
        public string StampIconPath { get; set; }
        public string UnstampIconName { get; set; }
        public string UnstampIconPath { get; set; }
        public string Code { get; set; }
        public int StatusId { get; set; }
        public DateTime Created { get; set; }
        public string Creator { get; set; }
        public DateTime LastModified { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual EventDet EventDet { get; set; }
    }
}
