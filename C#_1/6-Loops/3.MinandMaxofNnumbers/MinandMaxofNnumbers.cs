using System;

class MinandMaxofNnumbers
{
    static void Main()
    {
        Console.Write("Enter a positive number N = ");
        int N = int.Parse(Console.ReadLine());
        int NumberRead, NumberMax, NumberMin; 

        NumberMin = NumberMax = int.Parse(Console.ReadLine());

        for (int i = 2; i <= N; i++)
        {
            NumberRead = int.Parse(Console.ReadLine());
            if (NumberMin >= NumberRead)
            {
                NumberMin = NumberRead;       
            }
            if (NumberMax <= NumberRead)
            {
                NumberMax = NumberRead;
            }
        }
        Console.WriteLine("Max number is {0}", NumberMax);
        Console.WriteLine("Min number is {0}", NumberMin);
    }
}