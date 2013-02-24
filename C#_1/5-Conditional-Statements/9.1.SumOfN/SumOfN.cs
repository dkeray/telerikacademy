using System;

class SumOfN
{
    static void Main()
    {
        Console.WriteLine("Enter how many integers you will enter:");
        int n = int.Parse(Console.ReadLine());
        int[] NumArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            NumArray[i] = int.Parse(Console.ReadLine());
        }
    
        int count;
        int sum;
        for (int i = 1; i <= Math.Pow(2, n); i++)
        {
            count = 0;
            sum = 0;
            for (int pos = 0; pos < n; pos++)
            {
                if (((i & (1 << pos)) >> pos) == 1)
                    {
                        sum = sum + NumArray[pos];
                        count = 1;
                    }
            }

            if (sum == 0 & count == 1)
            {
                Console.WriteLine("There is sum of some subset is 0!!!");
                break;
            }
            if (i == Math.Pow(2, n))
            {
                Console.WriteLine("The answer is NO!");
            }
        }
    }
}