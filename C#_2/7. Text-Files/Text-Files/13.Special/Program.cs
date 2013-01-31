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
            string wordsfile = @"..\..\..\tests\words.txt";

            string[] words = File.ReadAllLines(wordsfile); 
            int[] values = new int[words.Length];

            string p = @"..\..\..\tests\specialin.txt";
            StreamReader input = new StreamReader(p);

            using (input)
            {
                string line = input.ReadLine();
                while (line != null)
                {
	                for (int i = 0; i < words.Length; i++)
                    values[i] += Regex.Matches(line, @"\b" + words[i] + @"\b").Count;
                    line = input.ReadLine();
                }
            }

            Array.Sort(values, words);

            string p1 = @"..\..\..\tests\specialout.txt";
            StreamWriter output = new StreamWriter(p1);

            using (output)
                for (int i = 0; i < words.Length; i++)
                    output.WriteLine("{0} times word: {1}", values[i], words[i]);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
