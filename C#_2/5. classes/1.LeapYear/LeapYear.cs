using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LeapYear
{
    static void Main()
    {
        DateTime christmas = new DateTime(2009, 12, 25);

        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Is {0} leap year: {1}",
          year, DateTime.IsLeapYear(year));

    }
}
