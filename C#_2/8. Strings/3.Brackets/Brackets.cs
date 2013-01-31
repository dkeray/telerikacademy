using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{

    public static bool CheckBrackets(string a)
    {
        int brackets = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == '(') brackets++;
            if (a[i] == ')') brackets--;
        }
        if (brackets == 0) return true;
        else return false;

    }

    static void Main()
    {
        Console.WriteLine(CheckBrackets(")(a+b))"));
    }
}