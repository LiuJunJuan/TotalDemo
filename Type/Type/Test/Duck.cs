using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Duck : IComparable<Duck>
    {
        public int Size;
        public int CompareTo(Duck other)
        {
            if (this.Size > other.Size)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
