using System;

class Program
{
    static void Main()
    {
        byte a = byte.Parse(Console.ReadLine());
        byte b = byte.Parse(Console.ReadLine());
        byte c = byte.Parse(Console.ReadLine());
        byte d = byte.Parse(Console.ReadLine());
        byte e = byte.Parse(Console.ReadLine());
        bool counter = true;
        uint devider = 1;
        while (counter)
        {
            if ((devider % a == 0) && (devider % b == 0) && (devider % c == 0) ||
                (devider % a == 0) && (devider % b == 0) && (devider % d == 0) ||
                (devider % a == 0) && (devider % b == 0) && (devider % e == 0) ||
                (devider % a == 0) && (devider % c == 0) && (devider % d == 0) ||
                (devider % a == 0) && (devider % c == 0) && (devider % e == 0) ||
                (devider % a == 0) && (devider % d == 0) && (devider % e == 0) ||
                (devider % b == 0) && (devider % c == 0) && (devider % d == 0) ||
                (devider % b == 0) && (devider % c == 0) && (devider % e == 0) ||
                (devider % c == 0) && (devider % d == 0) && (devider % e == 0))
            {
                counter = false;
                Console.WriteLine(devider);
            }
            devider++;
        }
    }
}