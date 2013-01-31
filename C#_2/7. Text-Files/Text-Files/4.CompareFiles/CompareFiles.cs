using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class CompareFiles
{
    static void Main()
    {
        string t1 = @"..\..\..\tests\textlines1.txt";
        string t2 = @"..\..\..\tests\textlines2.txt";
        StreamReader reader1 = new StreamReader(t1, Encoding.GetEncoding("windows-1251"));
        StreamReader reader2 = new StreamReader(t2, Encoding.GetEncoding("windows-1251"));

        using (reader1)
        {
            int lineNumber = 0;
            string linefile1 = reader1.ReadLine();
            string linefile2 = reader2.ReadLine();
            while (linefile1 != null)
            {
                lineNumber++;
                if (linefile1 == linefile2)
                {
                    Console.WriteLine("Line {0}. is the same.",lineNumber);
                } else Console.WriteLine("Line {0}. is the different.", lineNumber);
                linefile1 = reader1.ReadLine();
                linefile2 = reader2.ReadLine();
            }
        }
        reader2.Close();
    }
}
