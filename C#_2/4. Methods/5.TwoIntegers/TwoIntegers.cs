using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TwoIntegers
{
    static bool CheckBigger(int[] arr, int pos)
    {
        if (pos >= arr.Length)
        {
            return false;
        }
        else
            if (arr[pos] > arr[pos - 1] && arr[pos] > arr[pos + 1])
            {
                return true;
            }
            else return false;
    }

    static void Main(string[] args)
    {
        int[] arr = { 3, 4, 5, 6, 7, 4, 4, 4, 3, 2, 3, 2, 3, 5, 6, 7, 7 };

        int position = 4;

        Console.WriteLine("{0} positon of the array is bigger than its two neighbors --> {1}.", position, CheckBigger(arr,position));
    }
}
