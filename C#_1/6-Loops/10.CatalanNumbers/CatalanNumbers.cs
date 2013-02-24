using System;
using System.Numerics;

class CatalanNumbers
{
    static BigInteger Factoriel(decimal a)
    {
        BigInteger fact = 1;
        for (int i = 1; i <= a; i++)
        {
            fact *= i;
        }
        return fact;
    }

    static void Main()
    {
        Console.Write("Enter N = ");
        decimal n = decimal.Parse(Console.ReadLine());
        BigInteger CatalanNumber = 0;
        CatalanNumber = Factoriel(2 * n) / (Factoriel(n + 1) * Factoriel(n));
        Console.WriteLine("Catalan N number is {0}", CatalanNumber);
    }
}