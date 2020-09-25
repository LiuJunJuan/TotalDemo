using System;

namespace C_book_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(1,-1,0);
            Vector vector2 = new Vector(2,-2,-4);
            Vector vector3 = vector1 + vector2;

            Console.ReadKey();
        }
    }
}
