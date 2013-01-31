using System;
using System.Text;

class ToUnicode
{
    static void Main()
    {

        Console.WriteLine(ConvertToUnicode("Hi!"));

    }

    private static string ConvertToUnicode(string p)
    {
        
        StringBuilder result = new StringBuilder();
        foreach (var ch in p)
        {            
            result.AppendFormat("\\u{0:X4}",(int)ch);
        }


        return result.ToString();
    }
}