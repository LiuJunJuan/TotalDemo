using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Duck> ducks =new List<Duck>
           {
               new Duck{Size = 3},
               new Duck{Size = 1},
               new Duck{Size = 2},
           };
           ducks.Sort();
           Console.ReadKey();
        }
    }
}
