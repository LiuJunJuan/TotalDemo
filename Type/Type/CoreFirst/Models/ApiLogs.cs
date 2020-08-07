using System;
using System.Collections.Generic;

namespace CoreFirst.Models
{
    public partial class ApiLogs
    {
        public int LogId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Desc { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string Creator { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
