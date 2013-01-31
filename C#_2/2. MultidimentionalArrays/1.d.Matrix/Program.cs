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
        int count = 1;
        int start = 0;
        int end = n;

        while (end - start > 0)
        {

            for (int i = start; i < end; i++)
            {
                matrix[i, start] = count;
                count++;
            }
            for (int i = start+1; i < end; i++)
            {
                matrix[end - 1, i] = count;
                count++;
            }
            for (int i = end - 2; i >= start; i--)
            {
                matrix[i, end -1] = count;
                count++;
            }
            for (int i = end - 2; i >= start + 1; i--)
            {
                matrix[start, i] = count;
                count++;
            }
            start++;
            end--;
        }

        PrintMatrix(matrix);
    }
}