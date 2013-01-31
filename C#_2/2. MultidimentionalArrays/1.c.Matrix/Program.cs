using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void PrintMatrix(int[,] m)
    {
        for (int row = 0; row < m.GetLength(0); row++)
        {
            for (int col = 0; col < m.GetLength(1); col++)
            {
                Console.Write("{0,4}", m[row, col]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int i = 1;
        for (int y = 0; y < n * 2 - 1; y++)
        {

            int row = n - 1 - y;
            int col = 0;
            if (row < 0)
            {
                row = 0;
            }

            if (y >= n)
            {
                col = y - n + 1;
            }

            while ((row < n) && (col < n))
            {
                matrix[row, col] = i;
                i++;
                row++;
                col++;
            }
        }

        PrintMatrix(matrix);
    }
}