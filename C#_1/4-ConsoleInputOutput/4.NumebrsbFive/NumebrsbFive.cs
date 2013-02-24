using System;

    class NumbersbyFive
    {
        static void Main()
        {
            uint a = uint.Parse(Console.ReadLine());
            uint b = uint.Parse(Console.ReadLine());
            int counter = 0;
            for (uint i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                   counter++;
                } 
            }            
            Console.WriteLine("p({0},{1}) = {2}" ,a, b,
                counter);
        }
    }