using System;

class SumOfN
{
    static void Main()
    {
        long s = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        long[] NumArray = new long[n];
        for (int i = 0; i < n; i++)
        {
            NumArray[i] = long.Parse(Console.ReadLine());
        }

        long sum;
        long answer = 0;
        for (int i = 1; i <= Math.Pow(2, n)-1; i++)
        {
            sum = 0;
            for (int pos = 0; pos < n; pos++)
            {
                if (((i >> pos) & 1) == 1)
                {
                    sum = sum + NumArray[pos];
                }
            }

            if (sum == s)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
    }
}