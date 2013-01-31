using System;
using System.Collections.Generic;
using System.Linq;

class ComOfKElem
{

    static void CombinationsOfKElements(int[] arr, int n, int current, int index)
    {
        if (index == arr.Length)
        {
            Console.Write("{");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("}");
        }
        else
        {
            for (int i = current; i <= n; i++)
            {
                arr[index] = i;
                CombinationsOfKElements(arr, n, i+1 ,index + 1);
            }
        }
    }


    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[k];
        CombinationsOfKElements(arr, n, 1, 0);
    }
}
