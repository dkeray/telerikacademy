using System;

class Zeros
{
    static void Main()
    {
        Console.Write("Enter N =");
        int N = int.Parse(Console.ReadLine());

        int i = 1;
        int sum = 0;
        while (Math.Pow(5,i) < N)
        {
            sum += (int)(N / Math.Pow(5, i));
            i++;
        }
        Console.WriteLine("The count of trailing zeros in {0}! is {1}", N, sum);
    }
}