using System;
using System.Collections.Generic;
using System.Linq;

class SortBinSearch
{
    static void Main()
    {
        Console.Write("Enter N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K=");
        int k = int.Parse(Console.ReadLine());
       // int[] arr = { 76, 45, 34, 23, 54, 87, 45, 4, 2, 5, 6, 7, 8, 3, 4, 2, 5, 6, 5, 23, 45, 43 };
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter {0} element of {1}: ", i, n);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);

        int result = Array.BinarySearch(arr, k);

        while (result < 0)
        {
            if (k < arr[0])
            {
                break;
            }
            k--;
            result = Array.BinarySearch(arr, k);
        }

        if (result < 0)
        {
            Console.WriteLine("NO!");
        }
        else
            Console.WriteLine("Yes --> " + arr[result]);
    }
}
