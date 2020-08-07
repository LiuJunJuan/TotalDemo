using System;
using System.Collections.Generic;

namespace CoreFirst.BlogEf
{
    public partial class EventCard
    {
        public int CardId { get; set; }
        public int EventHdrId { get; set; }
        public int SlotCount { get; set; }
        public string BackendDesc { get; set; }
        public string PrizeName { get; set; }
        public string PrizePath { get; set; }
        public int StatusId { get; set; }
        public DateTime Created { get; set; }
        public string Creator { get; set; }
        public DateTime LastModified { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual EventHdr EventHdr { get; set; }
    }
}
