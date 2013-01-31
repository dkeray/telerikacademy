using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexToBin
{
    static string HextoBinary(string hex)
    {
        string sum = "";
        for (int i = 0; i < hex.Length; i++)
        {
            string a = "";
            switch (hex[i])
            {
                case '0': a = "0000"; break;
                case '1': a = "0001"; break;
                case '2': a = "0010"; break;
                case '3': a = "0011"; break;
                case '4': a = "0100"; break;
                case '5': a = "0101"; break;
                case '6': a = "0110"; break;
                case '7': a = "0111"; break;
                case '8': a = "1000"; break;
                case '9': a = "1001"; break;
                case 'A': a = "1010"; break;
                case 'B': a = "1011"; break;
                case 'C': a = "1100"; break;
                case 'D': a = "1101"; break;
                case 'E': a = "1110"; break;
                case 'F': a = "1111"; break;
                default: break;
            }
            sum += a;
        }
        return sum;
    }

    static void Main()
    {
        Console.WriteLine(HextoBinary("4F"));
    }
}
