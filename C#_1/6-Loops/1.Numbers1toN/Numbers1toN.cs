using System;

class Numbers1toN
{
    static void Main()
    {
        Console.Write("Enter positive integer N = ");
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(i);
        }
    }
}