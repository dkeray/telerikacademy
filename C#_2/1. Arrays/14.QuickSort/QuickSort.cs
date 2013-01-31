using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
  
    static void QuickSort(int[] arr, int left, int right)
    {
        int leftS = left;
        int rightS = right;
        int pivot = arr[(left + right)/2];
        while (left <= right)
        {
            while (arr[left] < pivot)
            {
                left++;
            }
            while (arr[right] > pivot)
            {
                right--;
            }
            if (left <= right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
            
        }

        if (leftS < right)
        {
            QuickSort(arr, leftS, right);
        }
        if (left < rightS)
        {
            QuickSort(arr, left, rightS);
        }
  
    }

    static void Main()
    {
        int [] arr = { 1, 2, 3, 34, 4, 5, 6 };

        QuickSort(arr, 0, arr.Length - 1);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
