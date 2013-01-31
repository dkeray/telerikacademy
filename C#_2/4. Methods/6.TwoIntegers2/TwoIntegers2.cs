using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TwoIntegers2
{
    static int CheckBigger(int[] arr)
    {
        for (int i = 1; i < arr.Length-1; i++)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                return i;
            }
        }
        return -1;
    }
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 8, 2, 3, 2, 3, 5, 6, 7, 7 };

        Console.WriteLine(CheckBigger(arr));

    }
}
