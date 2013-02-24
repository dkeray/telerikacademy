using System;

class Math_exression

{
    static void Main()
    {
        double N = double.Parse(Console.ReadLine());
        double M = double.Parse(Console.ReadLine());
        double P = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F6}", (N * N + 1 / (M * P) + 1337) / (N - 128.523123123 * P) + Math.Sin((int)(M % 180)));
    }
}   