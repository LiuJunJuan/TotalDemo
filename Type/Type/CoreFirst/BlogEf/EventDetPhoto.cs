using System;
using System.Collections.Generic;

namespace CoreFirst.BlogEf
{
    public partial class EventDetPhoto
    {
        public int EventDetPhotoId { get; set; }
        public int EventDetId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public bool IsCover { get; set; }
        public bool IsMap { get; set; }
        public int StatusId { get; set; }
        public DateTime Created { get; set; }
        public string Creator { get; set; }
        public DateTime LastModified { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual EventDet EventDet { get; set; }
    }
}
