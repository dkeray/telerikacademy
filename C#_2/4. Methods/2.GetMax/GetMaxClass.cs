using System;
using System.Collections.Generic;

class GetMaxClass
{
    static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else return b;
    }

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine(GetMax(a, GetMax(b,c)));
    }
}