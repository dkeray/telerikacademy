using System;

namespace BoolFloat
{
    class BoolFloat
    {
        static void Main()
        {
            bool a = (5.3f == 6.01f);
            bool b = (5.00000001f == 5.00000003f);
            Console.WriteLine("{0} \n {1}", a, b);
        }
    }
}