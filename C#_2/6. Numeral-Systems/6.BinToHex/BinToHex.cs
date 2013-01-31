using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinToHex
{
    static string BinarytoHex(string bin)
    {
        string sum = "";
        if (bin.Length % 4 != 0)
        {
            return "Error! you give not a full bit binary number fold to 4!";
        }
        for (int i = 0; i < bin.Length; i = i+4)
        {
            string digit = "";
            for (int y = i; y < i+4; y++)
            {
                digit += bin[y];
            }
            string a = "";
            switch (digit)
            {
                case "0000": a = "0"; break;
                case "0001": a = "1"; break;
                case "0010": a = "2"; break;
                case "0011": a = "3"; break;
                case "0100": a = "4"; break;
                case "0101": a = "5"; break;
                case "0110": a = "6"; break;
                case "0111": a = "7"; break;
                case "1000": a = "8"; break;
                case "1001": a = "9"; break;
                case "1010": a = "A"; break;
                case "1011": a = "B"; break;
                case "1100": a = "C"; break;
                case "1101": a = "D"; break;
                case "1110": a = "E"; break;
                case "1111": a = "F"; break;
                default: break;
            }
            sum += a;
        }
        return sum;
    }

    static void Main()
    {
        Console.WriteLine(BinarytoHex("00100011111110101101"));
    }
}
