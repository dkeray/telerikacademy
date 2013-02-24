using System;

class BinaryDigitsCount
{
    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        uint ReadNum = 0;

        for (int i = 1; i <= n; i++)
        {
            ReadNum = uint.Parse(Console.ReadLine());
            int count = 0;
            while (ReadNum != 0)
            {
                if ((ReadNum & 1) == b)
                {
                    count++;
                }
                ReadNum = ReadNum >> 1;             
            }
            Console.WriteLine(count);
        }
    }
}

