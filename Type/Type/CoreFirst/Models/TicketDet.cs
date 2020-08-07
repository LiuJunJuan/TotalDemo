using System;
using System.Collections.Generic;

namespace CoreFirst.Models
{
    public partial class TicketDet
    {
        public TicketDet()
        {
            TicketDetCode = new HashSet<TicketDetCode>();
        }

        public int TicketDetId { get; set; }
        public int TicketHdrId { get; set; }
        public int OrderDetId { get; set; }
        public int EventDetId { get; set; }
        public DateTime? AttractionDate { get; set; }
        public string SlotTimeFrom { get; set; }
        public string SlotTimeTo { get; set; }
        public int? SlotId { get; set; }
        public int StatusId { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string Creator { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual EventDet EventDet { get; set; }
        public virtual OrderDet OrderDet { get; set; }
        public virtual EventTimeSlot Slot { get; set; }
        public virtual TicketHdr TicketHdr { get; set; }
        public virtual ICollection<TicketDetCode> TicketDetCode { get; set; }
    }
}
