using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountOfNumber
{
    static int CountDigit(int[] arr, int number)
    {
        int Count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number)
            {
                Count++;
            }
        }
        return Count;
    }
    
    static void Main()
    {
        int[] arr = { 3, 4, 5, 6, 7, 4, 4, 4, 3, 2, 3, 2, 3, 5, 6, 7, 7 };

        Console.WriteLine(CountDigit(arr,6));


    }
}