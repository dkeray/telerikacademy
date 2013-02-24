using System;

class OddOrEven
{
    static void Main()
    {
        int cr = int.Parse(Console.ReadLine());
        Console.WriteLine((cr % 2) == 0 ? "The Number is Even" : "The number is Odd");
    }
}