using System;

class GCD
{
    static void Main()
    {
        Console.Write("Enter first number n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter first number m = ");
        int m = int.Parse(Console.ReadLine());

        int helper;
        while (n % m != 0)
        {          
            helper = n % m;
            n = m;
            m = helper;
        } 
        Console.WriteLine("The geatest common devisor is {0}.", m);
    }
}