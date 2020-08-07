using System;
using System.Collections.Generic;

namespace CoreFirst.Models
{
    public partial class TicketHdr
    {
        public TicketHdr()
        {
            TicketDet = new HashSet<TicketDet>();
            TicketHdrCode = new HashSet<TicketHdrCode>();
        }

        public int TicketHdrId { get; set; }
        public int EventHdrId { get; set; }
        public int OrderId { get; set; }
        public DateTime? TicketDate { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
        public int Amt { get; set; }
        public int StatusId { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string Creator { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual EventHdr EventHdr { get; set; }
        public virtual OrderHdr Order { get; set; }
        public virtual ICollection<TicketDet> TicketDet { get; set; }
        public virtual ICollection<TicketHdrCode> TicketHdrCode { get; set; }
    }
}
