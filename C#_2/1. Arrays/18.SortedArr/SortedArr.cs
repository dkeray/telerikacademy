using System;
using System.Collections.Generic;

class SortedArr
{
    static bool CheckSort (List<int> array)
    {
        bool sort = true;
        for (int i = 0; i < array.Count-1; i++)
		{
		    if (array[i] > array[i+1])
	        {
	            sort = false;
			}
        }
        return sort;
    }

    static void Main()
    {
        DateTime start = DateTime.Now;

        // Test data
          int[] arr = { 233, 12, 23, 4, 32, 5, 2, 6, 5, 56, 3, 234, 123, 45, 63, 23, 53, 342, 232 };
      //  int[] arr = { 6, 1, 4, 3, 0, 3, 6, 4, 5};
        int max = 0;
        List<int> result = new List<int>();

        for (int i = 1; i <= ((int)Math.Pow(2, arr.Length)-1); i++)
        {
            List<int> best = new List<int>();
            int counter = 0;
            for (int pos = 0; pos < arr.Length; pos++)
            {
                if (((i & (1 << pos)) >> pos) == 1)
                {
                    best.Add(arr[pos]);
                    counter++;
                }
            }

            if (counter > max && CheckSort(best))
            {
                max = counter;
                result = best;
            }

        }
        DateTime end = DateTime.Now;
        Console.WriteLine("Working time: {0}", end - start);
        for (int i = 0; i < result.Count; i++)
			{
			    Console.Write(result[i]+" ");
			}
        Console.WriteLine();
    }
}