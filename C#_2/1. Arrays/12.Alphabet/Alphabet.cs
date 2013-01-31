using System;
using System.Collections.Generic;
using System.Linq;

class Alphabet
{
    static void Main()
    {
        char[] arr = new char[26];
        int y = 65;
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToChar(y);
            y++;
        }

        int c = 0;
        do
        {
            c = Console.Read();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == c)
                {
                    Console.WriteLine("The index of letter {0} --> {1}", arr[i], i);
                }
            }
        } while (c != 10);

    }
}
