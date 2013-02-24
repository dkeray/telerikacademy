using System;

class Geatest7Numbers
{
    static void Main()
    {

    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    double d = double.Parse(Console.ReadLine());
    double e = double.Parse(Console.ReadLine());
    double max=a;
        if (a > max)
        {
            max = a;
        }
        if (b > max)
        {
            max = b;
        }
        if (c > max)
        {
            max = c;
        }
        if (d > max)
        {
            max = d;
        }
        if (e > max)
        {
            max = e;
        }
        Console.WriteLine(max);
    }
}