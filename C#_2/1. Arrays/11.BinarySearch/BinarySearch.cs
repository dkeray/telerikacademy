using System;
using System.Collections.Generic;
using System.Linq;

class BinarySearch
{
    static int BinSearch(int[] arr, int searchnum)
    {
        int Max = arr.Length - 1;
        int Min = 0;
        while (Max >= Min)
        {
            int mid = (Max + Min) / 2;
            if (arr[mid] < searchnum)
            {
                Min = mid + 1;
            }
            else if (arr[mid] > searchnum)
            {
                Max = mid - 1;
            }
            else return mid;
        }
        return -1;
    }

    static void Main()
    {
        int[] array = { 1, 1, 3, 3, 4, 7, 9, 12, 34, 35, 56, 57, 67, 78, 89 };
         
        int search = 78;
        int result = BinSearch(array, search);
        if (result == -1)
	        {
		         Console.WriteLine("The number is not in the array!");
	        }
        else Console.WriteLine(result);
    }
}
