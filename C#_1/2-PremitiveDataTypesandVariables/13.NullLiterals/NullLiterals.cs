using System;

namespace NullLiterals
{
    class Program
    {
        static void Main()
        {
            int? nullInteger = null;
            Console.WriteLine(nullInteger);
            double? nullDouble = null;
            Console.WriteLine(nullDouble);
            nullInteger = 3;
            nullDouble = 234;
            Console.WriteLine(nullInteger);
            Console.WriteLine(nullDouble);
        }
    }
}
