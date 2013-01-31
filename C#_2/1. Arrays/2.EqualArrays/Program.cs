using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter elenght of first array:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter elenght of second array:");
        int m = int.Parse(Console.ReadLine());
        if (n != m)
        {
            Console.WriteLine("Arrays are not equal!");
            return;
        }

        int[] arr1 = new int[n];
        int[] arr2 = new int[n];
        bool equal = true;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter value of the first array with index [{0}]",i);
            arr1[i] = int.Parse(Console.ReadLine());
            Console.Write("Enter value of the second array with index [{0}]", i);
            arr2[i] = int.Parse(Console.ReadLine());
            if (arr1[i] != arr2[i])
            {
                Console.WriteLine("Arrays are not equal!");
                return;
            }
        }
        Console.WriteLine("Arrays are equal!");
    }
}
