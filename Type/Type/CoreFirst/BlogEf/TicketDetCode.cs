using System;
using System.Collections.Generic;

namespace CoreFirst.BlogEf
{
    public partial class TicketDetCode
    {
        public int CodeId { get; set; }
        public int TicketDetId { get; set; }
        public string Code { get; set; }
        public int TicketStatusId { get; set; }
        public int StatusId { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string Creator { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual TicketDet TicketDet { get; set; }
    }
}
