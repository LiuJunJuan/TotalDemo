using System;
using System.Collections.Generic;

namespace CoreFirst.Models
{
    public partial class MemberStamp
    {
        public int MemberStampId { get; set; }
        public int MemberId { get; set; }
        public int EventDetId { get; set; }
        public string Name { get; set; }
        public int StatusId { get; set; }
        public DateTime Created { get; set; }
        public string Creator { get; set; }
        public DateTime LastModified { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual EventDet EventDet { get; set; }
        public virtual Member Member { get; set; }
    }
}
