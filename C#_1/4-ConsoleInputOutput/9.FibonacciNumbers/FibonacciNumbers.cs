using System;

class FibonacciNumbers
{
    static void Main()
    {
        uint f1 = 1;
        uint f2 = 1;
        uint fn;
        for (int i = 1; i <= 100; i++)
        {
            fn = f1 + f2;
            Console.Write("{0,-5}->   {1} \n", i, fn);
            f1 = f2;
            f2 = fn;
        }
    }
}
