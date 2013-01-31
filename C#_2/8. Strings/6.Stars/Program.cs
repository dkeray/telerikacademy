using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        StringBuilder s = new StringBuilder();
        s.Append('*',20);
        Console.WriteLine(s);
        int temp = 0;
        int pos = 0;
        while (true)
        { 
            temp = Console.Read();
            if (temp == 13 || pos == 20) break;
            s[pos] = (char)temp;
            pos++;

        }
        Console.WriteLine(s.ToString());
    }
}
