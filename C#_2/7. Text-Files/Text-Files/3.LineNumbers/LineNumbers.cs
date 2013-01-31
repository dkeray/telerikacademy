using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        string t1 = @"..\..\..\tests\text.txt";
        StreamReader reader1 = new StreamReader(t1, Encoding.GetEncoding("windows-1251"));

        string t2 = @"..\..\..\tests\textLineNumbers.txt";
        StreamWriter writer1 = new StreamWriter(t2, false, Encoding.GetEncoding("windows-1251"));

        using (reader1)
        {
            int lineNumber = 0;
            string line = reader1.ReadLine();
            while (line != null)
            {
                lineNumber++;
                writer1.WriteLine("{0,3}. {1}",lineNumber, line);
                line = reader1.ReadLine();
            }
        }
        writer1.Close();
    }
}
