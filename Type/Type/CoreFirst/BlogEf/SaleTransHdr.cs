using System;
using System.Collections.Generic;

namespace CoreFirst.BlogEf
{
    public partial class SaleTransHdr
    {
        public SaleTransHdr()
        {
            SaleTransDet = new HashSet<SaleTransDet>();
        }

        public int SaleTransHdrId { get; set; }
        public int EventHdrId { get; set; }
        public int OrderId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int TotalQty { get; set; }
        public int Amt { get; set; }
        public int Discount { get; set; }
        public int ShippingFee { get; set; }
        public int EarnPoints { get; set; }
        public int MemberAddressId { get; set; }
        public int StatusId { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string Creator { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual EventHdr EventHdr { get; set; }
        public virtual OrderHdr Order { get; set; }
        public virtual ICollection<SaleTransDet> SaleTransDet { get; set; }
    }
}
