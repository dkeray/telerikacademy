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
        int direction = 0;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (direction == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = i;
                    i++;
                }
            }
            else
            {
                for (int row = matrix.GetLength(0)-1; row <= 0; row--)
                {
                    matrix[row, col] = i;
                    i++;
                }
            }


        }

        PrintMatrix(matrix);
    }
}