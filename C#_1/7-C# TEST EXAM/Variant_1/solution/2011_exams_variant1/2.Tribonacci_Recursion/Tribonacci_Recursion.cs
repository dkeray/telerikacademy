using System;
using System.Numerics;

class Tribonacci_Recursion
{
    static BigInteger t1 = BigInteger.Parse(Console.ReadLine());
    static BigInteger t2 = BigInteger.Parse(Console.ReadLine());
    static BigInteger t3 = BigInteger.Parse(Console.ReadLine());

    static BigInteger Tribonacci(int n)
    {
        if (n == 1)
            return t1;
        if (n == 2)
            return t2;
        if (n == 3)
            return t3;
        return (Tribonacci(n - 1) + Tribonacci(n - 2) + Tribonacci(n - 3));
    }

    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Tribonacci(n));
    }
}

