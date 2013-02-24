using System;
namespace ExchnageValues
{
    class ExchnageValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine(a);
            Console.WriteLine(b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Values are exchanged");
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}