using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class TwoFiles
{
    static void Main()
    {
        string t1 = @"..\..\..\tests\text.txt";
        string t2 = @"..\..\..\tests\text2.txt";
        StreamReader reader1 = new StreamReader(t1, Encoding.GetEncoding("windows-1251"));
        StreamReader reader2 = new StreamReader(t2, Encoding.GetEncoding("windows-1251"));
        string fileContents1 = reader1.ReadToEnd();
        string fileContents2 = reader2.ReadToEnd();
        reader1.Close();
        reader2.Close();

        string t = @"..\..\..\tests\textout.txt";
        StreamWriter streamWriter = new StreamWriter(t, false, Encoding.GetEncoding("windows-1251"));
        streamWriter.WriteLine(fileContents1 + fileContents2);
        streamWriter.Close();
    }
}
