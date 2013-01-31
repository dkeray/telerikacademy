using System;
using System.Collections.Generic;
using System.Linq;

class CharArrays
{
    static void Main()
    {
        int[] a = new int[1000];
        int[] b = new int[1000];
        Console.Write("Enter first char array: ");
        int temp = Console.Read();
        int y = 0;
        do
        {
            a[y] = temp;
            temp = Console.Read();
            y++;
        } while (temp != 10);
        Console.WriteLine();
        Console.Write("Enter second char array: ");
        temp = Console.Read();
        y = 0;
        do
        {
            b[y] = temp;
            temp = Console.Read();
            y++;
        } while (temp != 10);
        Console.WriteLine();

        int maxlenght = b.Length;
        int minlenght = b.Length;
        if (a.Length > b.Length)
            {
                maxlenght = a.Length;
            }
         if (a.Length < b.Length)
            {
                minlenght = a.Length;
            }
        for (int i = 0; i < maxlenght; i++)
        {
            if (i == a.Length)
            {
                Console.WriteLine("Lexicographically array is first array.");
                return;
            }
            if (i == b.Length)
            {
                Console.WriteLine("Lexicographically array is second array.");
                return;
            }
            if (a[i] != b[i])
            {
                if (a[i] < b[i]) 
		                Console.WriteLine("Lexicographically array is first array.");
                else Console.WriteLine("Lexicographically array is second array.");
                return;
            }
        }
        Console.WriteLine("Arrays are equal!");
    }
}