using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{

    public static string ReverseString(string a)
    {
        char[] arr = a.ToCharArray();
        Array.Reverse(arr);
        string result = new string(arr);
        return result;
    }

    static void Main()
    {
        Console.WriteLine(ReverseString("didokeray"));
    }
}