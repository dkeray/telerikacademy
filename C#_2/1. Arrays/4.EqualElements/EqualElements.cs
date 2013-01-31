using System;
using System.Collections.Generic;
using System.Linq;

class EqualElements
{
    static void Main()
    {
        int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        int count = 1;
        int maxcount = 1;
        int equalelement = 0;
        for (int i = 0; i < arr.Length-1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                count++;
            }
            else { if (maxcount < count) {maxcount = count; equalelement = arr[i];} count = 1; }
        }
        Console.Write("[");
        for (int i = 1; i <= maxcount-1; i++)
        {
            Console.Write("{0}, ",equalelement);
        }
        Console.WriteLine("{0}"+"]",equalelement);
        Console.WriteLine("Count of equal elements: {0}" , maxcount);
        Console.WriteLine("Equal elements: {0}",equalelement);
    }
}
