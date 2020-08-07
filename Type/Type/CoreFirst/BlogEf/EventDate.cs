using System;
using System.Collections.Generic;

namespace CoreFirst.BlogEf
{
    public partial class EventDate
    {
        public int EventDateId { get; set; }
        public int EventHdrId { get; set; }
        public int MaxQty { get; set; }
        public int CurrentQty { get; set; }
        public DateTime Date { get; set; }
        public int StatusId { get; set; }
        public DateTime Created { get; set; }
        public string Creator { get; set; }
        public DateTime LastModified { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual EventHdr EventHdr { get; set; }
    }
}
