using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class ReadsFile
{
    static void Main()
    {
        string p = @"..\..\..\tests\text.txt";
        StreamReader reader = new StreamReader(p, Encoding.GetEncoding("windows-1251"));
        string fileContents = reader.ReadToEnd();
        Console.WriteLine(fileContents);
        reader.Close();

    }
}
