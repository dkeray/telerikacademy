using System;

class Trapezoid
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        byte width = n;
        for (int y = 1; y < n+1; y++)
        {
            for (int x1 = 1; x1 <= n; x1++)
            {
                if (x1 == n - y+2)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }         
            }
            for (int x2 = 1; x2 <= n-1; x2++)
            {
                if (y == 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine("*");
        }
        for (int i = 1; i < 2*n; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine("*");
    }
}