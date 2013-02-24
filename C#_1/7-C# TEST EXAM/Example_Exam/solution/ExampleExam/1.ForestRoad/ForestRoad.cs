using System;

class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= n; col++)
            {
                if (row == col)
                {
                    Console.Write("*");
                }
                else
                    Console.Write(".");
            }
            Console.WriteLine();
        }

        for (int row = 1; row <= n-1; row++)
        {
            for (int col = 1; col <= n; col++)
            {
                if (n-row == col)
                {
                    Console.Write("*");
                }
                else
                    Console.Write(".");
            }
            Console.WriteLine();
        }


    }
}
