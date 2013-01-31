using System;
using System.Collections.Generic;
using System.Linq;

class EratosthenesPrimeNumbers
{
    static void Main()
    {
        List<int> num = new List<int>();
  //      DateTime start = DateTime.Now;
        num.Add(2);
        num.Add(3);
        num.Add(5);
        for (int i = 6; i <=  10000000; i++)
        {

            if ((i % 2 == 0) || (i % 3 == 0) || (i % 5 == 0))
            {
                continue;
            }
            else num.Add(i);
        }
 //       DateTime end = DateTime.Now;
  //      Console.WriteLine(" {0}", end - start);
        for (int i = 0; i < num.Count; i++)
        {
            if (i % 15 == 0) Console.WriteLine();
            Console.Write("{0,9}", num[i]);

        }
        Console.WriteLine();
    }
}