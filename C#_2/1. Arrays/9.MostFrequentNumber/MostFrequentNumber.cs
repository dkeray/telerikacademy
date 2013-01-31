using System;
using System.Collections.Generic;
using System.Linq;

class MostFrequentNumber
{
    static void Main()
    {
        int[] arr = { 10, 3, 4, 4, 2, 40, 5, 5, 5, 5, 432, 5, 4, 2, 4, 3 };

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int min = arr[i];
            int minindex = i;
            for (int y = i + 1; y < arr.Length; y++)
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


        int sum = 0, number = 0, maxsum = 0;
        for (int i = 0; i < arr.Length-1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                sum++;
                if (maxsum <= sum)
                {
                    maxsum = sum;
                    number = arr[i];
                }
            }
            else
            {
                sum = 0;
            }
        }
        Console.WriteLine("{0} ({1} times)", number, maxsum);
    }
}