using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxElement
{
    static int MaxElem(int[] arr, int startpos, int endpos)
    {
        int max = arr[startpos];
        for (int i = startpos; i < endpos; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }

    static int[] SortArrDesc(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int temp = arr[i];
            int max = MaxElem(arr, i, arr.Length);
            arr[Array.IndexOf(arr, max)] = temp;
            arr[i] = max;
        }
        return arr;
    }

    static int[] SortArrAsc(int[] arr)
    {
        for (int i = arr.Length-1; i >= 0 ; i--)
        {
            int temp = arr[i];
            int max = MaxElem(arr, 0, i+1);
            arr[Array.IndexOf(arr, max)] = temp;
            arr[i] = max;
        }
        return arr;
    }

    static void PrintArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0,4}", arr[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] nums = { 18, 46, 55, 64, 23, 42, 5, 23, 31, 53, 6, 73, 39 };
        int pos = 4;

        Console.WriteLine("{0,4}",MaxElem(nums, pos, nums.Length));

        Console.Write("Descending order --> ");
        PrintArr(SortArrDesc(nums));
        Console.Write("Ascending order  --> ");
        PrintArr(SortArrAsc(nums));


    }
}

