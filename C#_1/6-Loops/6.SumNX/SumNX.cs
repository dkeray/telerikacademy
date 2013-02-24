using System;

class SumNX
{
    static void Main()
    {
        Console.Write("Enter interger number N = ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter integer number X = ");
        int X = int.Parse(Console.ReadLine());
        double Sum = 1;
        for (int i = 1; i <= N; i++)
        {
            double FactI = 1;
            double SqrI = X;
            for (int y = 1; y <= i; y++)
            {
                FactI *= y;
                SqrI *= X;
            }
            Sum += FactI / SqrI;
        }
        Console.WriteLine(Sum);
    }
}
