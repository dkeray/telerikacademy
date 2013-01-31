using System;
using System.Collections.Generic;
using System.Linq;

class MaxKSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Test input data
        //int k = 2;
        //int[] arr = { 1, 3, 4, 6, 2, 4, 5, 3, 5, 3, 4, 2, 3, 8, 75, 16, 1, 2, 1, 2, 5 };
        //int n = arr.Length;
        
        int maxsum = 0;
        int maxsumindex = 0;
        for (int i = 0; i < n-k+1; i++)
        {
            int sum = 0;
            for (int y = i; y < i+k; y++)
            {
                sum += arr[y];
            }
            if (maxsum < sum)
            {
                maxsum = sum;
                maxsumindex = i;
            }
        }

        Console.WriteLine("Max sum is: {0}", maxsum);
        Console.Write("{ ");
        for (int i = maxsumindex; i < maxsumindex+k; i++)
        {
            Console.Write("{0}, ",arr[i]);
        }
        Console.WriteLine("}");
    }
}
