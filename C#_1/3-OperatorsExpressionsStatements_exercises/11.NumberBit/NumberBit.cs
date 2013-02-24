using System;

class NumberBit
{
    static void Main()
    {
        int i = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());              //Position of bit
        Console.WriteLine(Convert.ToString(i, 2).PadLeft(32, '0'));
        int bit = (i & (1 << b)) >> b;
        Console.WriteLine("The {0} bit after 0 in the entered number {1} is {2}", b, i, bit);

    }
}