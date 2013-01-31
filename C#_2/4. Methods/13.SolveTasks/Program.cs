using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void PrintMenu()
    {
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("|  1. Reverses the digits of a number                   |");
        Console.WriteLine("|  2. Calculates the average of a sequence of integers  |");
        Console.WriteLine("|  3. Solves a linear equation a * x + b = 0            |");
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine();
    }

    static void Choice()
    {
        Console.Write("Enter your choice (1 / 2 / 3): ");
        int c = int.Parse(Console.ReadLine());

        switch (c)
        {
            case 1:
                Console.Write("Enter a number that will be reversed: ");
                decimal num = decimal.Parse(Console.ReadLine());
                if (num < 0)
                    Console.WriteLine("The decimal is under 0! Try again later!");
                else Console.WriteLine("Reverdsed number is: {0}",ReverseNumber(num)); 
                break;

            case 2: 
                Console.Write("Enter how many integer will be entered: ");
                int n = int.Parse(Console.ReadLine());
                int[] nums = new int[n];
                if (n < 1)
                    Console.WriteLine("Entered number is under 1.Try again later!");
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        Console.Write("Enter integer at {0} position: ", i);
                        nums[i - 1] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Average number is: {0}", AverageNumber(nums)); 
                }                     
                break;

            case 3: 
                Console.Write("Enter a: ");
                decimal a = decimal.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                decimal b = decimal.Parse(Console.ReadLine());
                if (a == 0)
                    Console.WriteLine("a should not be equal to 0. Try again later!");
                else
                    Console.WriteLine("The answer is: {0:F3}",LinearEquation(a,b));
                break;

            default: Console.WriteLine("You must enter enteger betwen 1 and 3!");
                break;
        }
    }

    private static decimal LinearEquation(decimal a, decimal b)
    {
        decimal result = -b / a;
        return result;
    }

    private static int AverageNumber(int[] nums)
    {
        int result = 0;
       
        for (int i = 0; i < nums.Length; i++)
        {
            result += nums[i];
        }
        result = result / (nums.Length);

        return result;
    }

    private static decimal ReverseNumber(decimal a)
    {
        string temp = Convert.ToString(a);
        string result = "";
        for (int i = temp.Length - 1; i >= 0; i--)
        {
            result += temp[i];
        }
        return Convert.ToDecimal(result);
    }

    
    static void Main()
    {
        PrintMenu();
        Choice();
    }
}
