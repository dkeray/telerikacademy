using System;

class Radius
{
    static void Main()
    {
            
        double r = double.Parse(Console.ReadLine());
        double perimetar = 2* Math.PI * r;
        double area = Math.PI * r * r;
        Console.WriteLine("Perimeter of circle is: {0}", perimetar);
        Console.WriteLine("Area of circle is: {0} ", area);

    }
}