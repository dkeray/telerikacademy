using System;

class Raandom1
{
    static void Main()
    {
        Random randomGenerator1 = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(randomGenerator1.Next(100,201));
        }

    }
}
