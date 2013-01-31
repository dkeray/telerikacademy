using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sum
{
    static void Main()
    {
        string num = "43 68 9 23 318";

        string[] nums = num.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        int sum = 0;
        foreach (string i in nums)
        {
            sum += Convert.ToInt32(i);
        }
        Console.WriteLine(sum);
    }
}
