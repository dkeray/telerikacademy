using System;

class Sort3RealNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("\n\n\n\n\n");
        // In case of a is bigger
        if (a >= b && a >= c)
        {
            Console.WriteLine(a);
            if (b >= c)
            {
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(c);
                Console.WriteLine(b);
            }
        }
        //in case of b is bigger
        if (b >= c && b >= a)
        {
            Console.WriteLine(b);
            if (a >= c)
            {
                Console.WriteLine(a);
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(c);
                Console.WriteLine(a);
            }
        }
        // in case of c is bigger
        if (c >= b && c >= a)
        {
            Console.WriteLine(c);
            if (a >= b)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
        }
    }
}