using System;
using System.Collections.Generic;
using System.Linq;

class VarOfKElem
{

    static void VariationsOfKElements(int[]arr ,int n, int index)
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
            for (int i = 1; i <= n; i++)
            {
                arr[index] = i;
                VariationsOfKElements(arr, n, index + 1);
            }
        }
    }


    static void Main()
    {  
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());     
        int[] arr = new int[k];
        VariationsOfKElements(arr, n, 0);   
    }
}
