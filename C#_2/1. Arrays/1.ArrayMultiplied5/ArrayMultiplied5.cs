using System;
using System.Collections.Generic;
using System.Linq;

class ArrayMultiplied5
{
    static void Main()
    {
        int[] arr = new int[20];
        for (int i = 0; i < 20; i++)
        {
            arr[i] = i * 5;
        }

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
