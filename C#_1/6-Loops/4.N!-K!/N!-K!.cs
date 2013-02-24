using System;

class Program
{
    static void Main()
    {
        int N, K;
        decimal FactK, FactN;
        FactK = FactN = 1;
        do
        {
            Console.Write("Enter N = ");
            N = int.Parse(Console.ReadLine());
        }
        while (N < 1);

        do
        {
            Console.Write("Enter K = ");
            K = int.Parse(Console.ReadLine());
        }
        while (K > N || K < 1);

            for (int i = 1; i <= N; i++)
            {
                FactN *= i;
            }
            for (int i = 1; i <= K; i++)
            {
                FactK *= i;
            }
            Console.WriteLine("{0}! / {1}! = {2}", N, K, FactN / FactK);

    }
}
