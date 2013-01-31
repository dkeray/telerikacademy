using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseNumber
{
    static decimal Reverse(decimal a)
    {
        string temp = Convert.ToString(a);
        string result = "";
        for (int i = temp.Length-1; i >=0 ; i--)
		{
            result += temp[i];
        }


        return Convert.ToDecimal(result);
    }


    static void Main()
    {

        decimal num = -123456789.43m;

        Console.WriteLine(Reverse(num));

    }
}