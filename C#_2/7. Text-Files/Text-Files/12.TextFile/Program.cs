using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


class Program
{
    static void Main()
    {

        try
        {
            string regex = @"\b(" + String.Join("|", File.ReadAllLines("../../../tests/words.txt")) + @")\b";
            string p = @"..\..\..\tests\textfilein.txt";
            StreamReader input = new StreamReader(p);
            string p1 = @"..\..\..\tests\textfileout.txt";
            StreamWriter output = new StreamWriter(p1);
            string line = input.ReadLine();
            while (line != null)
            {
                output.WriteLine(Regex.Replace(line, regex, ""));
                line = input.ReadLine();
            }
            input.Close();
            output.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
    }
}
