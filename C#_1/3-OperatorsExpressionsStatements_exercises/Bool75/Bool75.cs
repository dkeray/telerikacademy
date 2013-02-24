using System;

class Bool75
{
    static void Main()
    {
        int cr = int.Parse(Console.ReadLine());
        Console.WriteLine((cr % 5 == 0) && (cr % 7 == 0) ? "True" : "False");

    }
}