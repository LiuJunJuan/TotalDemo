using System;
using System.Collections.Generic;

namespace CoreFirst.Models
{
    public partial class SaleTransDet
    {
        public int SaleTransDetId { get; set; }
        public int SaleTransHdrId { get; set; }
        public int OrderDetId { get; set; }
        public int ProductId { get; set; }
        public string Sku { get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
        public int UnitPrice { get; set; }
        public int Amt { get; set; }
        public int Discount { get; set; }
        public int? ReviewLv { get; set; }
        public string ReviewComment { get; set; }
        public int StatusId { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string Creator { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual OrderDet OrderDet { get; set; }
        public virtual SaleTransHdr SaleTransHdr { get; set; }
    }
}
