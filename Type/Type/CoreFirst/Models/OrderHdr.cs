using System;
using System.Collections.Generic;

namespace CoreFirst.Models
{
    public partial class OrderHdr
    {
        public OrderHdr()
        {
            OrderDet = new HashSet<OrderDet>();
            SaleTransHdr = new HashSet<SaleTransHdr>();
            TicketHdr = new HashSet<TicketHdr>();
        }

        public int OrderId { get; set; }
        public int MemberId { get; set; }
        public string WeChatOpenId { get; set; }
        public string WeChatName { get; set; }
        public string WeChatPrePayId { get; set; }
        public string OrderType { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalQty { get; set; }
        public int TotalAmt { get; set; }
        public int PaymentStatusId { get; set; }
        public int OrderStatusId { get; set; }
        public DateTime PaymentDate { get; set; }
        public int StatusId { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string Creator { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual Member Member { get; set; }
        public virtual ICollection<OrderDet> OrderDet { get; set; }
        public virtual ICollection<SaleTransHdr> SaleTransHdr { get; set; }
        public virtual ICollection<TicketHdr> TicketHdr { get; set; }
    }
}
