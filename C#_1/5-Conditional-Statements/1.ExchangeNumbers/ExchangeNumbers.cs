using System;

class ExchangeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers first and second:");
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int helper;
        if (first > second)
        {
            helper = first;
            first = second;
            second = helper;
            Console.WriteLine("The numbers was exchanged. First number {0}, second number {1}", first, second);
        }
        else
        {
            Console.WriteLine("The number is not exchanged. First number {0}, second number {1}", first, second);
        }
    }
}