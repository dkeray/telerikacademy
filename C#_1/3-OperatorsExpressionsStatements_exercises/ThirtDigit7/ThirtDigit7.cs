using System;

class ThirtDigit7
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine((a / 100 % 10 == 7) ? "True" : "False");
    }
}