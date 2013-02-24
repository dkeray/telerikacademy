using System;
namespace HelloWorld
{
    class HelloWorld
    {
        static void Main()
        {
            string a = "Hello";
            string b = "World";
            object hw = a + " " + b;
            string c = (string)hw;
            Console.WriteLine(c);
        }
    }
}