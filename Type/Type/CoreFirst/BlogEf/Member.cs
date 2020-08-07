using System;
using System.Collections.Generic;

namespace CoreFirst.BlogEf
{
    public partial class Member
    {
        public Member()
        {
            MemberAddress = new HashSet<MemberAddress>();
            MemberPoint = new HashSet<MemberPoint>();
            MemberStamp = new HashSet<MemberStamp>();
            OrderHdr = new HashSet<OrderHdr>();
        }

        public int MemberId { get; set; }
        public string WeChatOpenId { get; set; }
        public string Name { get; set; }
        public string MemberCardNo { get; set; }
        public string SessionKey { get; set; }
        public string AvatarUrl { get; set; }
        public DateTime ExpiredDate { get; set; }
        public int LevelId { get; set; }
        public int TotalPoints { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string Creator { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual ICollection<MemberAddress> MemberAddress { get; set; }
        public virtual ICollection<MemberPoint> MemberPoint { get; set; }
        public virtual ICollection<MemberStamp> MemberStamp { get; set; }
        public virtual ICollection<OrderHdr> OrderHdr { get; set; }
    }
}
