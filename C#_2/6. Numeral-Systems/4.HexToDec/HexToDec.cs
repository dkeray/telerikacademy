using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexToDec
{
    static int CharToDec(char ch)
    {
        int a = 0;
        switch (ch)
            {
                case '0': a = 0; break;
                case '1': a = 1; break;
                case '2': a = 2; break;
                case '3': a = 3; break;
                case '4': a = 4; break;
                case '5': a = 5; break;
                case '6': a = 6; break;
                case '7': a = 7; break;
                case '8': a = 8; break;
                case '9': a = 9; break;
                case 'A': a = 10; break;
                case 'B': a = 11; break;
                case 'C': a = 12; break;
                case 'D': a = 13; break;
                case 'E': a = 14; break;
                case 'F': a = 15; break;
                default: break;
            }
        return a;
    }

    static int HexToDecimal(string hex)
    {
        int sum = 0;
        for (int i = 0; i < hex.Length; i++)
        {
           
            int b = (int)Math.Pow(16, hex.Length - 1 - i);
            sum = sum + (CharToDec(hex[i]) * b);
        }
        return sum;
    }

    static void Main()
    {
        Console.WriteLine(HexToDecimal("ABCDEF"));
    }
}