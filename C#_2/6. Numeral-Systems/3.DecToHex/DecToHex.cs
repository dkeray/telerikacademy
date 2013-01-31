using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecToHex
{

    public static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    static string DecimalToHex(int dec)
    {
        int temp = dec;
        string sum = "";
        do
        {
            int ostatak = (temp - ((temp / 16) * 16));
            if (ostatak > 9)
            {
                switch (ostatak)
                {
                    case 10: sum += "A"; break;
                    case 11: sum += "B"; break;
                    case 12: sum += "C"; break;
                    case 13: sum += "D"; break;
                    case 14: sum += "E"; break;
                    case 15: sum += "F"; break;
                    default: break;
                }
            } else sum += ostatak;
            temp /= 16;
        } while (temp != 0);
       
        return ReverseString(sum);
    }


    static void Main()
    {
        Console.WriteLine(DecimalToHex(50000));
    }
}
