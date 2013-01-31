using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string p = @"..\..\..\tests\test.txt";
        StreamReader input = new StreamReader(p);
        string p1 = @"..\..\..\tests\test1.txt";
        StreamWriter output = new StreamWriter(p1);
        string line = input.ReadLine();
        while (line != null)
        {
            output.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
            line = input.ReadLine();
        }
        input.Close();
        output.Close();
    }
}
