using System;

class SumOf5
{
    static void Main()
    {
        Console.WriteLine("Enter 5 integers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        int count;
        int sum;
        for (int i = 1; i <= 32; i++)
			{
                count = 0;
                sum = 0;
                if (((i & (1 << 0)) >> 0) == 1)
                {
                    sum = sum + a;
                    count = 1;
                }
                if (((i & (1 << 1)) >> 1) == 1)
                {
                    sum = sum + b;
                    count = 1;
                }
                if (((i & (1 << 2)) >> 2) == 1)
                {
                    sum = sum + c;
                    count = 1;
                }
                if (((i & (1 << 3)) >> 3) == 1)
                {
                    sum = sum + e;
                    count = 1;
                }
                if (((i & (1 << 4)) >> 4) == 1)
                {
                    sum = sum + d;
                    count = 1;
                }
                if (sum == 0 & count == 1)
                {
                    Console.WriteLine("There is sum of some subset is 0!!!");
                    break;
                }
                if (i == 32)
                {
                    Console.WriteLine("The answer is NO!");
                }
			}
    }
}