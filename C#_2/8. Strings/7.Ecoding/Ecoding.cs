using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ecoding
{


    static void Main()
    {
        string encodingstr = "123456";
        string text = "dido wil go today to work and will win a price!";
        string encodedtext = EncodeString(text, encodingstr);
        Console.WriteLine(encodedtext);

        string decodedtext = DecodeString(encodedtext, encodingstr);
        Console.WriteLine(decodedtext);


    }

    private static string EncodeString(string text, string encodingstr)
    {
        StringBuilder result = new StringBuilder();
        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            char temp = Convert.ToChar((int)text[i] ^ (int)encodingstr[count]);
            result.Append(temp);
            if (count == encodingstr.Length-1)
            {
                count = 0;
            }
            else count++;
        }
        return result.ToString();
    }

    private static string DecodeString(string text, string encodingstr)
    {
        StringBuilder result = new StringBuilder();
        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            char temp = Convert.ToChar((int)text[i] ^ (int)encodingstr[count]);
            result.Append(temp);
            if (count == encodingstr.Length - 1)
            {
                count = 0;
            }
            else count++;
        }
        return result.ToString();
    }
}
