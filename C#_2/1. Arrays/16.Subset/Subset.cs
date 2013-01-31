using System;
using System.Collections.Generic;

class Subset
{
    static void Main()
    {

        int[] arr = { 2, 1, 2, 4, 3, 5, 2, 6, 5, 56, 3, 234, 123, 45, 63, 23, 53, 342, 232 };
        int s = 155;
        List<int> best = new List<int>();

        int count;
        int sum;
        for (int i = 1; i <= Math.Pow(2, arr.Length); i++)
        {
            count = 0;
            sum = 0;
            for (int pos = 0; pos < arr.Length; pos++)
            {
                if (((i & (1 << pos)) >> pos) == 1)
                {
                    sum = sum + arr[pos];
                    count = 1;
                    best.Add(arr[pos]);
                }
            }

            if (sum == s & count == 1)
            {
                Console.Write("yes ==> ");
                for (int y = 0; y < best.Count; y++)
                {
                    Console.Write(best[y]+ "+");
                }
                Console.WriteLine("="+s);
                break;
            }


            if (i == Math.Pow(2, arr.Length))
            {
                Console.WriteLine("NO!");
            }


            best.Clear(); // clear the list fir the subset
        }
    }
}