using System;

class ReturnBit
{
    static void Main()
    {
        int v = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());              //Position of bit
        Console.WriteLine(Convert.ToString(v, 2).PadLeft(16, '0'));
        int bit = (v & (1 << p)) >> p;
        bool result = Convert.ToBoolean(bit);
        Console.WriteLine("The {0} bit after 0 in the entered number {1} is 1? -> {2}", p, v, bit);

    }
}