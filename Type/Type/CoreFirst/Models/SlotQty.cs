using System;
using System.Collections.Generic;

namespace CoreFirst.Models
{
    public partial class SlotQty
    {
        public int SlotQtyId { get; set; }
        public int SlotId { get; set; }
        public DateTime AttractionDate { get; set; }
        public int CurrentQty { get; set; }
        public int EventDetId { get; set; }
        public int StatusId { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string Creator { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual EventDet EventDet { get; set; }
        public virtual EventTimeSlot Slot { get; set; }
    }
}
