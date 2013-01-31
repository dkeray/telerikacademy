using System;
using System.Collections.Generic;
using System.Linq;

class MaxIncreesing
{
    static void Main()
    {
        int[] arr = { 3, 4, 3, 2, 2, 2, 4 };
        int count = 1;
        int maxcount = 1;
        int equalelement = 0;
        int index = 0;
        for (int i = 0; i < arr.Length-1; i++)
        {
            if (arr[i] + 1 == arr[i + 1])
            {
                count++;
            }
            else { if (maxcount < count) { maxcount = count; equalelement = arr[i]; index = i; } count = 1; }
        }

        for (int i = index-maxcount+1; i <= index; i++)
        {
            Console.Write("{0}, ",arr[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Count of increesing elements: {0}" , maxcount);
    }
}
