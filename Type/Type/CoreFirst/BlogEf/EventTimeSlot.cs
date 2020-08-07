using System;
using System.Collections.Generic;

namespace CoreFirst.BlogEf
{
    public partial class EventTimeSlot
    {
        public EventTimeSlot()
        {
            SlotQty = new HashSet<SlotQty>();
            TicketDet = new HashSet<TicketDet>();
        }

        public int SlotId { get; set; }
        public int EventDetId { get; set; }
        public DateTime? ExceptionDate { get; set; }
        public string TimeSlotType { get; set; }
        public string TimeSlotFrom { get; set; }
        public string TimeSlotTo { get; set; }
        public int MaxQty { get; set; }
        public int StatusId { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string Creator { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual EventDet EventDet { get; set; }
        public virtual ICollection<SlotQty> SlotQty { get; set; }
        public virtual ICollection<TicketDet> TicketDet { get; set; }
    }
}
