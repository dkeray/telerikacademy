using System;

class Hello
{
    static void HelloPrint()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!",name);
    }

    static void Main()
    {
        HelloPrint();
    }
}
