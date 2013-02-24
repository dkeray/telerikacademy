using System;

class NNumbers
{
    static void Main()
    {
        Console.Write("Enter unsigned integer number n = ");
        uint n = uint.Parse(Console.ReadLine());
        int[] enteredN = new int[99999];
  
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter n[{0}] : ", i);
            enteredN[i] = int.Parse(Console.ReadLine());
            
        }
        Console.WriteLine();
        for (int i = 1; i <= n; i++)
        {
            Console.Write("n[{0}] = ",i);
            Console.WriteLine(enteredN[i]);
        }
    }
}