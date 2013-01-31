using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LastDigit
{
    static string GetLastDigit(int a)
    {
        string[] digits = {"zero" , "one", "two","three","four","five","six","seven","eight","nine"};
        return digits[a % 10];

    }

    static void Main()
    {
        int a = 1024;
        Console.WriteLine(GetLastDigit(a));
    }
}

