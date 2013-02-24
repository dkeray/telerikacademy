using System;

class Fibonacci
{
    static void Main()
    {
        Console.Write("Enter N = ");
        int N = int.Parse(Console.ReadLine());
        int last = 0;
        int newlast = 1;
        int helper = 0;
        double sum = 0;
        for (int i = 1; i <= N; i++)
        {
            helper = last;
            last = newlast;
            newlast += helper;
            Console.WriteLine("{0}, ",newlast);
            sum += newlast;
        }
        Console.WriteLine("The sum is {0}.", sum);
    }
}

