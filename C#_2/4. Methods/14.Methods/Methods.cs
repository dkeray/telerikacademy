using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Methods
{
    static void Main()
    {
        //Console.Write("Enter how many integer you will enter: ");
        //int n = int.Parse(Console.ReadLine());
        //if (n < 1)
        //{
        //    Console.WriteLine("Entered number is under 1. Try again later!");
        //    return;
        //}
        //int[] nums = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Enter integer at position {0}: ", i);
        //    nums[i] = int.Parse(Console.ReadLine());
        //}

        // test data 
        int[] nums = { 1, 2, 3, 5, 3, 4, 2, 5, 6, 7, 4, 2, 1, 3, 4, 8, 9, 3, 4, 2, 3, 42 };
        
        Console.WriteLine();

        Console.Write("The minimum integer is: ");
        Console.WriteLine(MinNum(nums));
        Console.WriteLine();

        Console.Write("The maximum integer is: ");
        Console.WriteLine(MaxNum(nums));
        Console.WriteLine();

        Console.Write("The average integer is: ");
        Console.WriteLine(AvergeNum(nums));
        Console.WriteLine();

        Console.Write("The sum of integers is: ");
        Console.WriteLine(SumNums(nums));
        Console.WriteLine();

        Console.Write("The product of integers is: ");
        Console.WriteLine(ProdutNums(nums));
        Console.WriteLine();

    }

    private static double ProdutNums(int[] nums)
    {
        double product = 1;
        for (int i = 1; i < nums.Length; i++) product *= nums[i];
        return product;
    }

    private static int SumNums(int[] nums)
    {
        int sum = 0;
        for (int i = 1; i < nums.Length; i++) sum += nums[i];
        return sum;
    }

    private static int AvergeNum(int[] nums)
    {
        int sum = 0;
        for (int i = 1; i < nums.Length; i++) sum += nums[i];
        return sum / nums.Length;
    }

    private static int MaxNum(int[] nums)
    {
        int max = nums[0];
        for (int i = 1; i < nums.Length; i++) if (max < nums[i]) max = nums[i];
        return max;
    }

    private static int MinNum(int[] nums)
    {
        int min = nums[0];
        for (int i = 1; i < nums.Length; i++) if (min > nums[i] ) min = nums[i];
        return min;
    }
}
