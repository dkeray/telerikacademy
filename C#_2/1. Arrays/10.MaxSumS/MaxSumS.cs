using System;
using System.Collections.Generic;
using System.Linq;

class MaxSumS
{
    static void Main()
    {
        int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
        int s = 11;
        int MaxSum = 0;
        int MaxStartIndex = 0;
        int MaxEndIndex = 0;
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum = 0;
            for (int y = i; y < arr.Length; y++)
            {
                sum += arr[y];
                if (sum == s)
                {
                    MaxStartIndex = i;
                    MaxEndIndex = y;
                    MaxSum = 1;
                    break;
                }
            }
        }
        if (MaxSum == 0)
        {
            Console.WriteLine("There is no such sum");
        }
        else
        for (int i = MaxStartIndex; i <= MaxEndIndex; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
