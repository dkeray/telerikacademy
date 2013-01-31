using System;
using System.Collections.Generic;
using System.Linq;

class MaxSum
{
    static void Main()
    {
        int[] arr = { 1, 4, 5, -4, 3, 5, 3, -6, -2, 9, 12 };
        int MaxSum = 0;
        int MaxStartIndex = 0;
        int MaxEndIndex = 0;
        int sum = 0;
        int start = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            if (MaxSum < sum)
            {
                MaxSum = sum;
                MaxStartIndex = start;
                MaxEndIndex = i;
            }
            if (sum < 0)
            {
                sum = 0;
                start = i + 1;
            }
        }

        for (int i = MaxStartIndex; i <= MaxEndIndex; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}