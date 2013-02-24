using System;

class IntPrime
{
    static void Main()
    {
        Console.Write("Enter a positive integer (n<=100) n=");
        uint n = uint.Parse(Console.ReadLine());
        bool a = true;
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine("The number n={0} is NOT prime",n);
                a = false;
                break;
            }    
        }    
            if (a == true) 
            {
                Console.WriteLine("The number n={0} is prime",n);
            }
    }
}