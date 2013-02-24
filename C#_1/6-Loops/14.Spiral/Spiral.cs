using System;

class Spiral
{
    static void Main()
    {
        Console.Write("Enter N = ");
        int N = int.Parse(Console.ReadLine());

        int[,] Matrix = new int[N, N];
        int counter = 1;
        int start = 0;
        int end = N;
        while (counter <= N * N)
        {
            for (int i = start; i < end; i++)
            {
                Matrix[start, i] = counter;
                counter++;
            }
            for (int i = start + 1; i < end; i++)
            {
                Matrix[i, end - 1] = counter;
                counter++;
            }
            for (int i = end - 2; i >= start; i--)
            {
                Matrix[end - 1, i] = counter;
                counter++;
            }
            for (int i = end - 2; i >= start + 1; i--)
            {
                Matrix[i, start] = counter;
                counter++;
            }
            start++;
            end--;
        }

        for (int row = 0; row < Matrix.GetLength(0); row++)
        {
            for (int col = 0; col < Matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", Matrix[row, col]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}