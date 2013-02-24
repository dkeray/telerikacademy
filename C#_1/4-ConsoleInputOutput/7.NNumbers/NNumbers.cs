using System;

class NNumbers
{
    static void Main()
    {
        Console.Write("Enter unsigned integer number n = ");
        uint n = uint.Parse(Console.ReadLine());
        double enteredN;
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter n[{0}] : ",i);
            enteredN = double.Parse(Console.ReadLine());
            sum += enteredN;
        }
        Console.WriteLine("\nSum = {0}",sum);
    }
}