using System;

class Bits

{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            long p = long.Parse(Console.ReadLine());
            long pNew = 0;
            while (true)
            {

                pNew = pNew | ( p & 1);
                
                p = p >> 1;
                if (p==0) break;
                pNew = pNew << 1;
            }
            Console.WriteLine(pNew);
        }

    }
}
