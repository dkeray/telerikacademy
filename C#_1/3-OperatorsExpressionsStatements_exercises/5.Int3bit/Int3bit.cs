using System;

    class Int3bit
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine()); 
            int p = 3;                                                  //Position of bit
            Console.WriteLine(Convert.ToString(a, 2).PadLeft(16, '0'));
            int bit = (a & (1 << p)) >> p;
            Console.WriteLine("The 3th bit after 0 in the entered number is {0}",bit);

        }
    }