using System;
using System.Collections.Generic;

namespace CoreFirst.BlogEf
{
    public partial class EventHdr
    {
        public EventHdr()
        {
            EventCard = new HashSet<EventCard>();
            EventDate = new HashSet<EventDate>();
            EventDet = new HashSet<EventDet>();
            EventHdrPhoto = new HashSet<EventHdrPhoto>();
            SaleTransHdr = new HashSet<SaleTransHdr>();
            TicketHdr = new HashSet<TicketHdr>();
        }

        public int EventHdrId { get; set; }
        public string Title { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public bool IsDateSpecified { get; set; }
        public bool IsHot { get; set; }
        public string Address { get; set; }
        public string PromotionIcon { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public DateTime Created { get; set; }
        public string Creator { get; set; }
        public DateTime LastModified { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<EventCard> EventCard { get; set; }
        public virtual ICollection<EventDate> EventDate { get; set; }
        public virtual ICollection<EventDet> EventDet { get; set; }
        public virtual ICollection<EventHdrPhoto> EventHdrPhoto { get; set; }
        public virtual ICollection<SaleTransHdr> SaleTransHdr { get; set; }
        public virtual ICollection<TicketHdr> TicketHdr { get; set; }
    }
}
