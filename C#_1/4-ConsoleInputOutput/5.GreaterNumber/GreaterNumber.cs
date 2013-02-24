using System;

    class GreaterNumber
    {
        static void Main()
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = a - b;
            long k = (c >> 63) & 1;
            long max = a - k * c;
            Console.WriteLine(max);
        }
    }