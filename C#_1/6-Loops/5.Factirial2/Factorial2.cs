using System;

class Factorial2
{
    static void Main()
    {
        int N, K;
        decimal FactK, FactN, FactNK;
        FactK = FactN = FactNK = 1;
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
        for (int i = 1; i <= (K-N); i++)
        {
            FactNK *= i;
        }

        Console.WriteLine("({0}! * {1}!) / ({0}-{1})! = {2}", N, K, (FactN * FactK) / FactNK);

    }
}
