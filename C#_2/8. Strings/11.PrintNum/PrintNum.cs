using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintNum
{

    static void Main()
    {
        int decvalue = 1231;

        Console.WriteLine("{0,15}", decvalue);

        Console.WriteLine("{0,15:X}", decvalue);

        Console.WriteLine("{0,15:P}", decvalue);

        Console.WriteLine("{0,15:E}", decvalue);
    }
}