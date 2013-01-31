using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinToDecimal
{
    static int BinaryToDecimal(string bin)
    {
        int sum = 0;
        for (int i = 0; i < bin.Length; i++)
        {
            int a = Convert.ToInt32(bin[i] + "");
            int b = (int)Math.Pow(2, bin.Length - 1 - i);
            sum = sum + (a * b);
        }
        return sum;
    }


    static void Main()
    {
        Console.WriteLine(BinaryToDecimal("110101010111010011101"));
    }
}
