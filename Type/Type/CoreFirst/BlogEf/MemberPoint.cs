using System;
using System.Collections.Generic;

namespace CoreFirst.BlogEf
{
    public partial class MemberPoint
    {
        public int MemberPointId { get; set; }
        public int MemberId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int PointChange { get; set; }
        public int OrderId { get; set; }
        public int StatusId { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string Creator { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual Member Member { get; set; }
    }
}
