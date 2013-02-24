using System;

class Trapezoid
{
    static void Main()
    {
        Console.Write("Enter an positive number for side a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter an positive number for side b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter an positive number for height h=");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("The area of trapezoid is {0}", (6 * ((a + b) / 2)));
    }
}