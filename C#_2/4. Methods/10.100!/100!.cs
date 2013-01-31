using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class 100!
{

    static BigInteger Factorial(int n)
    {
        BigInteger fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }

    static int[] AddNum(int[] a, int[] b)
    {
        if (a.Length > b.Length) return AddNum(b, a); // We want a <= b

        int[] result = new int[b.Length + 1]; // 1 + 99 = 100

        int i = 0, carry = 0;

        for (; i < a.Length; i++)
        {
            result[i] = (byte)(a[i] + b[i] + carry);

            carry = result[i] / 10;
            result[i] %= 10;
        }

        for (; i < b.Length && carry != 0; i++)
        {
            result[i] = (byte)(b[i] + carry);

            carry = result[i] / 10;
            result[i] %= 10;
        }

        for (; i < b.Length; i++) result[i] = b[i];

        if (carry != 0) result[i] = 1;
        else Array.Resize(ref result, result.Length - 1);

        return result;
    }

    static int[] Multipies(int[] x, int y)
    {
        int[] result = { 0 };

        for (int i = 0; i < y; i++) 
                result = AddNum(result, x);

        return result;
    }


    static void PrintArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0}", arr[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] factorial = { 1 };
        for (int i = 1; i <= 100; i++)
        {
            factorial = Multipies(factorial, i);
        }
        Array.Reverse(factorial);
        PrintArr(factorial);                // do it with multiplies
        Console.WriteLine(Factorial(100)); // do it with BigInteger
    }
}
