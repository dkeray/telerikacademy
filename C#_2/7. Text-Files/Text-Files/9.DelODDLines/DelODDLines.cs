using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

class DelODDLines
{
    static void Main()
    {
        string p = @"..\..\..\tests\deloddlines.txt";
        StreamReader reader = new StreamReader(p, Encoding.GetEncoding("windows-1251"));
        List<string> text = new List<string>();
        int lineNumber = 0;

        string line = reader.ReadLine();
        while (line != null)
        {
            text.Add(line);
            line = reader.ReadLine();
            line = reader.ReadLine();
            lineNumber ++;
        }
        reader.Close();

        StreamWriter writer = new StreamWriter(p);
        for (int i = 0; i < text.Count; i++)
        {
            writer.WriteLine(text[i]);
        }
        writer.Close();
    }
    Regex.
}
