using System;

class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n-1; i++)
        {
                Console.Write(new string('.',n-2-i));
                Console.Write(new string('*',i));
                Console.Write("*");
                Console.Write(new string('*', i));
                Console.Write(new string('.', n - 2 - i));
                Console.WriteLine();
        }
        Console.Write(new string('.', n - 2));
        Console.Write(new string('*', 0));
        Console.Write("*");
        Console.Write(new string('*', 0));
        Console.Write(new string('.', n - 2));
        Console.WriteLine();

    }
}