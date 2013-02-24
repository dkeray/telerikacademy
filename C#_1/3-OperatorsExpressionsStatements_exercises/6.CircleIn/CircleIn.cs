using System;

class CircleIn
{
    static void Main()
    {
        int xCircle = 0;
        int yCircle = 0;
        int radius = 5;
        Console.Write("Enter x: ");
        int xPoint = int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        int yPoint = int.Parse(Console.ReadLine());

        bool result = (((xPoint - xCircle) * (xPoint - xCircle)) + ((yPoint - yCircle) * (yPoint - yCircle))) <= (radius*radius);
        Console.WriteLine("The point is in the circle, is {0}", result);    
    }
}