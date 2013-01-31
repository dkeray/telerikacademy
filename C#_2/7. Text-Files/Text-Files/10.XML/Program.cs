using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    private static string RemoveTags(string line)
    {
        string result = "";
        int start = 0;
        for (int i = 0; i < line.Length; i++)
        {   
            if (line[i] == '<')
            {
                start = 0;  
            }
            if (start == 1)
            {
                result += (char)line[i];
            }
            if (line[i] == '>')
            {
                start = 1;
            }
        }

        return result;
    }

    static void Main()
    {
        string p = @"..\..\..\tests\plant_catalog.xml";
        StreamReader reader = new StreamReader(p);

        string line = reader.ReadLine();
        while (line != null)
        {
            Console.WriteLine(RemoveTags(line));
            line = reader.ReadLine();
        }
        reader.Close();
    }
}
