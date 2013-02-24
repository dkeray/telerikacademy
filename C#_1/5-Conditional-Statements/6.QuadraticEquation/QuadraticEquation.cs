using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter c = ");
        int c = int.Parse(Console.ReadLine());
        double d = b * b - 4 * a * c;
        double x;
        double x1 = 0;
        double x2 = 0;
        double f;
        if (d <= 0)
        {
            if (d == 0)
            {
                x = -b / 2 * a;
                Console.Write("Уравнението има един реален корен = ");
                Console.WriteLine(x);
            }
            else { Console.WriteLine("Уравнението няма реални корени!"); }
        }
        else
        {
            f = Math.Sqrt(b * b - 4 * a * c);
            x1 = (-b + f) / 2 * a;
            x2 = (-b - f) / 2 * a;
            Console.WriteLine("Уравнението има реални корени! \nКорен x1 = {0} ; Корен x2 = {1}", x1, x2);
        }

    }
}