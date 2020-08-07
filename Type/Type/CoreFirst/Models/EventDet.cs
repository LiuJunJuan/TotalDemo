using System;
using System.Collections.Generic;

namespace CoreFirst.Models
{
    public partial class EventDet
    {
        public EventDet()
        {
            EventDetPhoto = new HashSet<EventDetPhoto>();
            EventDetStamp = new HashSet<EventDetStamp>();
            EventTimeSlot = new HashSet<EventTimeSlot>();
            MemberStamp = new HashSet<MemberStamp>();
            SlotQty = new HashSet<SlotQty>();
            TicketDet = new HashSet<TicketDet>();
        }

        public int EventDetId { get; set; }
        public int EventHdrId { get; set; }
        public string SubEventType { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TimeFrom { get; set; }
        public string TimeTo { get; set; }
        public string MallLocation { get; set; }
        public string IconImage { get; set; }
        public string PromotionalMsg { get; set; }
        public int TicketPrice { get; set; }
        public int MaxQty { get; set; }
        public int StatusId { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string Creator { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual EventHdr EventHdr { get; set; }
        public virtual ICollection<EventDetPhoto> EventDetPhoto { get; set; }
        public virtual ICollection<EventDetStamp> EventDetStamp { get; set; }
        public virtual ICollection<EventTimeSlot> EventTimeSlot { get; set; }
        public virtual ICollection<MemberStamp> MemberStamp { get; set; }
        public virtual ICollection<SlotQty> SlotQty { get; set; }
        public virtual ICollection<TicketDet> TicketDet { get; set; }
    }
}
