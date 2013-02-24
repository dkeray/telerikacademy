using System;

namespace ASCIIPrint
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 127; i++)
            {
                Console.WriteLine("ASCI code " + i + "-> " + (char)i);
            }
        }
    }
}