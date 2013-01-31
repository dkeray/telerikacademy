using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AddNumbers
{

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

    static int[] ReadArray()
    {
        int[] result = new int[10000000];
        Console.Write("Enter first number: ");
        int temp = 0;
        int i = 0;
        while (temp != 10)
        {
            temp = Console.Read();
            result[i] = (int)(char)temp;
            i++;
        }
        Array.Reverse(result);
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
        int[] a = { 1, 4, 5, 6, 3, 4, 5, 2, 1, 5, 6, 7, 9 };
        int[] b = { 5, 4, 3, 5, 6, 8, 9, 4, 8 };

        int[] result = AddNum(a, b);
        Console.WriteLine("------------------------------------------ ");
        PrintArr(result);
    }
}