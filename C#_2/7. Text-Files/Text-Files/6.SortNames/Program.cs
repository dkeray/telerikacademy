using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class SortFile
{
    static void Main()
    {
        string p = @"..\..\..\tests\sortnames.txt";
        StreamReader reader = new StreamReader(p);

        int lineNumber = 0;
        
       
        List<string> names = new List<string>();
        string line = reader.ReadLine();
        while (line != null)
	        {
                names.Add(line);
                line = reader.ReadLine();
                lineNumber++;
	        }

        names.Sort();
        
        reader.Close();

        string p1 = @"..\..\..\tests\sortnames1.txt";
        StreamWriter writer = new StreamWriter(p1);

        for (int i = 0; i < names.Count; i++)
        {
            writer.WriteLine(names[i]);
        }
        writer.Close(); 
    }
}
