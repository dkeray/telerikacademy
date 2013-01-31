using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MethodsGeneric
{
    static void Main()
    {
        // test data 
        // int[] nums = { 1, 2, 3, 5, 3, 4, 2, 5, 6, 7, 4, 2, 1, 3, 4, 8, 9, 3, 4, 2, 3, 42 };

        Console.WriteLine();

        Console.Write("The minimum integer is: ");
        Console.WriteLine(MinNum(1, 2, 3, 5, 3, 4, 2, 5, 6, 7, 4, 2, 1, 3, 4, 8, 9, 3, 4, 2, 3, 42));
        Console.WriteLine();

        Console.Write("The maximum integer is: ");
        Console.WriteLine(MaxNum(1, 2, 3, 5, 3, 4, 2, 5, 6, 7, 4, 2, 1, 3, 4, 8, 9, 3, 4, 2, 3, 42));
        Console.WriteLine();

        Console.Write("The average integer is: ");
        Console.WriteLine(AvergeNum(1, 2, 3, 5, 3, 4, 2, 5, 6, 7, 4, 2, 1, 3, 4, 8, 9, 3, 4, 2, 3, 42));
        Console.WriteLine();

        Console.Write("The sum of integers is: ");
        Console.WriteLine(SumNums(1, 2, 3, 5, 3, 4, 2, 5, 6, 7, 4, 2, 1, 3, 4, 8, 9, 3, 4, 2, 3, 42));
        Console.WriteLine();

        Console.Write("The product of integers is: ");
        Console.WriteLine(ProdutNums(1, 2, 3, 5, 3, 4, 2, 5, 6, 7, 4, 2, 1, 3, 4, 8, 9, 3, 4, 2, 3, 42));
        Console.WriteLine();

    }

    private static T ProdutNums<T>(params T[] nums)
    {
        dynamic product = 1;
        for (int i = 1; i < nums.Length; i++) product *= nums[i];
        return product;
    }

    private static T SumNums<T>(params T[] nums)
    {
        dynamic sum = 0;
        for (int i = 1; i < nums.Length; i++) sum += nums[i];
        return sum;
    }

    private static T AvergeNum<T>(params T[] nums)
    {
        dynamic sum = 0;
        for (int i = 1; i < nums.Length; i++) sum += nums[i];
        return sum / nums.Length;
    }

    private static T MaxNum<T>(params T[] nums)
    {
        dynamic max = nums[0];
        for (int i = 1; i < nums.Length; i++) if (max < nums[i]) max = nums[i];
        return max;
    }

    private static T MinNum<T>(params T[] nums)
    {
        dynamic min = nums[0];
        for (int i = 1; i < nums.Length; i++) if (min > nums[i]) min = nums[i];
        return min;
    }
}
