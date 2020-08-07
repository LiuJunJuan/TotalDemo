using System;
using System.Collections.Generic;

namespace CoreFirst.Models
{
    public partial class MemberAddress
    {
        public int MemberAddressId { get; set; }
        public int MemberId { get; set; }
        public bool IsDefault { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string PostCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public int StatusId { get; set; }
        public string Address { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string Creator { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual Member Member { get; set; }
    }
}
