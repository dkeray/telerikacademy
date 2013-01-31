using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OpenFile
{
    static void Main()
    {
        string p = @"C:\Users\dkeray.DIDO\Desktop\file.txt";

        try
        {
            Console.WriteLine(System.IO.File.ReadAllText(p));
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception cought!\n{0}:{1}", e.GetType().Name, e.Message);
        }

    }
}