using System;
using System.Collections.Generic;

class Odd_number
{
    static void Main()
    {
        List<long> numbers = new List<long>();
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            long helper = long.Parse(Console.ReadLine());
            if (numbers.Contains(helper))
            {
                numbers.Remove(helper);
            }
            else
            {
                numbers.Add(helper);
            }
        }
        Console.WriteLine(numbers[0]);
    }
}