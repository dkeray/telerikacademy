using System;
using System.Collections.Generic;
using System.Linq;

class SortArray
{
    static void Main()
    {
        int[] arr = { 10, 3, 4, 6, 2, 40, 5,234,234,12,432,12,4,2,4,3 };

        for (int i = 0; i < arr.Length-1; i++)
        {
            int min = arr[i];
            int minindex = i;
            for (int y = i+1; y < arr.Length; y++)
            {
                if (arr[y] < min)
                {
                    min = arr[y];
                    minindex = y;
                }
            }
            arr[minindex] = arr[i];
            arr[i] = min;
         }
        
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0} ",arr[i]);
        }
    }
}