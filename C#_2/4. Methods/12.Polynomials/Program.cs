using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    static void PrintPolynomial(int[] arr)
    {
        for (int i = arr.Length - 1; i > 0; i--)
        {
            Console.Write(arr[i] + "*x^" + i + " + ");
        }
        Console.Write(arr[0]);
        Console.WriteLine();
    }

    static int[] AddNum(int[] a, int[] b, bool vadene)
    {
        if (a.Length > b.Length) return AddNum(b, a, vadene);

        int[] result = new int[b.Length];

        for (int i = 0; i < a.Length; i++)
        {
            result[i] = a[i] + (vadene ? -b[i] : b[i]);
        }
        for (int i = a.Length - 1; i < b.Length; i++)
        {
            result[i] = (vadene ? -b[i] : b[i]);
        }
        return result;
    }

    public static int[] Multiplies(int[] a, int[] b)
    {

        int[] result = new int[a.Length + b.Length - 1];

        for (int i = 0; i < a.Length; i++)
            for (int j = 0; j < b.Length; j++)
                result[i + j] += a[i] * b[j];

        return result;
    }

    static void Main()
    {
        int[] a = { 4, 5, 6, 2, 3, 4, 6 };
        int[] b = { 2, 5, 0, 3 };


        PrintPolynomial(a);
        PrintPolynomial(b);

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("-----------------------------------------------------------------------");
        PrintPolynomial(AddNum(a, b, false)); // add
        Console.WriteLine("-----------------------------------------------------------------------");
        PrintPolynomial(AddNum(a, b, true)); // subtraction
        Console.WriteLine("-----------------------------------------------------------------------");
        PrintPolynomial(Multiplies(a, b)); // subtraction
    }
}

