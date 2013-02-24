using System;

class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i <= n/2; i++)
        {
           
            Console.Write(new string('.',i));
            Console.Write(new string('*',(n/2-i)));
            Console.Write('*');
            Console.Write(new string('*', (n / 2 - i)));
            Console.Write(new string('.', i));
            Console.WriteLine();
        }
        for (int y = n/2-1; y >= 0; y--)
        {
            Console.Write(new string('.',y));
            Console.Write(new string('*',(n/2-y)));
            Console.Write('*');
            Console.Write(new string('*', (n / 2 - y)));
            Console.Write(new string('.', y));
            Console.WriteLine();
        }
    }
}
