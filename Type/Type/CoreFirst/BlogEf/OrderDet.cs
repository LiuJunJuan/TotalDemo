using System;
using System.Collections.Generic;

namespace CoreFirst.BlogEf
{
    public partial class OrderDet
    {
        public OrderDet()
        {
            SaleTransDet = new HashSet<SaleTransDet>();
            TicketDet = new HashSet<TicketDet>();
        }

        public int OrderDetId { get; set; }
        public int OrderId { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
        public int Amt { get; set; }
        public int StatusId { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string Creator { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual OrderHdr Order { get; set; }
        public virtual ICollection<SaleTransDet> SaleTransDet { get; set; }
        public virtual ICollection<TicketDet> TicketDet { get; set; }
    }
}
