using System;

class IntModify
{
    static void Main()
    {
        Console.Write("Enter value of n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value of p: ");
        int p = int.Parse(Console.ReadLine());           //Position of bit
        Console.Write("Enter value of v(0 or 1): ");
        int v = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        int bit;
        if (v == 0)
        {
            bit = (n & (~(1 << p)));
        }
        else
        {
            bit = (n | (1 << p));
        }
        Console.WriteLine("The number is {0}", bit);
        Console.WriteLine(Convert.ToString(bit, 2).PadLeft(32, '0'));
    }
}