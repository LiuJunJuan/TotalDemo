using System;
using System.Collections.Generic;

namespace CoreFirst.BlogEf
{
    public partial class EventHdrPhoto
    {
        public int EventHdrPhotoId { get; set; }
        public int EventHdrId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public bool IsCover { get; set; }
        public int StatusId { get; set; }
        public DateTime Created { get; set; }
        public string Creator { get; set; }
        public DateTime LastModified { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual EventHdr EventHdr { get; set; }
    }
}
