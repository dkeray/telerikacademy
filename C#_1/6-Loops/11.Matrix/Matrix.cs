using System;

class Matrix
{
    static void Main()
    {
        int n;
        do
        {
            Console.Write("Enter N<20 = ");
            n = int.Parse(Console.ReadLine());
        } while (n > 20 || n <= 0);

        for (int i = 1; i <= n; i++)
        {
            for (int y = i; y <= n+i-1; y++)
            {
                Console.Write("{0,3}", y);
            }
            Console.WriteLine();
        }
    }
}
