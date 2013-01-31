using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseSentence
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        string sign = Convert.ToString(text[text.Length-1]);
        text = text.Remove(text.Length-1);
        string[] s = text.Split(' ', ',');
    
        StringBuilder result = new StringBuilder();
        for (int i = s.Length-1; i >= 0; i--)
        {
            if (s[i] == "")
            {
                result.Remove(result.Length-1,1);
                result.Append(","); 
            } else result.Append(s[i]);
            result.Append(" ");
        }
        result.Remove(result.Length - 1, 1);
        Console.Write(result.ToString());
        Console.WriteLine(sign);
    }
}