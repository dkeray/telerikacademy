using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ConvertSystems1
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
            case 'G': a = 16; break;
            case 'H': a = 17; break;
            case 'I': a = 18; break;
            case 'J': a = 19; break;
            default: break;
        }
        return a;
    }

    public static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    static int XToDecimal(string number, int x)
    {
        int sum = 0;
        for (int i = 0; i < number.Length; i++)
        {

            int b = (int)Math.Pow(x, number.Length - 1 - i);
            sum = sum + (CharToDec(number[i]) * b);
        }
        return sum;
    }

    static string DecimalToX(int dec, int x)
    {
        int temp = dec;
        string sum = "";
        do
        {
            int ostatak = (temp - ((temp / x) * x));
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
                    case 16: sum += "G"; break;
                    case 17: sum += "H"; break;
                    case 18: sum += "I"; break;
                    case 19: sum += "J"; break;
                    default: break;
                }
            }
            else sum += ostatak;
            temp /= x;
        } while (temp != 0);

        return ReverseString(sum);
    }



    static void Main()
    {
        Console.Write("Please enter a number: ");
        string number = (Console.ReadLine()).ToUpper();
        Console.Write("Please enter the system of given base s: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Please enter the system of given base d: ");
        int d = int.Parse(Console.ReadLine());


        Console.WriteLine(DecimalToX(XToDecimal(number, s), d));

    }
}