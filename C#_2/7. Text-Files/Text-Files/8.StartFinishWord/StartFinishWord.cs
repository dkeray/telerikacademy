using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

class StartFinishWord
{
    static void Main()
    {
        string p = @"..\..\..\tests\startfinish.txt";
        StreamReader reader = new StreamReader(p);
        string p1 = @"..\..\..\tests\startfinishout.txt";
        StreamWriter writer = new StreamWriter(p1);
        int lineNumber = 0;

        string line = reader.ReadLine();
        while (line != null)
        {
            string temp = Regex.Replace(line, @"\bstart\b", "finish");
            writer.WriteLine(temp);
            line = reader.ReadLine();
            lineNumber++;
        }

        writer.Close();
        reader.Close();

    }
}
