using System;
using System.Collections.Generic;
using System.Linq;

class Permutation
{
    static void ChangePos(ref int first, ref int second)
    {
        int temp = first;
        first = second;
        second = temp;
    }

    static void CalcPermutation(int[] arr, int current, int lenght)
    {
        if (current == lenght)
        {
            Console.Write("{");
            for (int i = 0; i <= lenght; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("}");
        }
        else
        {
            for (int i = current; i <= lenght; i++)
            {
                ChangePos(ref arr[i], ref arr[current]);
                CalcPermutation(arr, current + 1, lenght);
                ChangePos(ref arr[i], ref arr[current]);
            }
        }
    }


    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 1; i <= n; i++)
        {
            arr[i - 1] = i;
        }


        CalcPermutation(arr, 0, arr.Length-1);
    }
}
