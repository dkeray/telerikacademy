using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WorkDays
{
    static void Main()
    {
        // input
        Console.WriteLine("Enter a end date in YYYY/MM/DD format");
        string[] endDateStr = Console.ReadLine().Split('/');
        int day = int.Parse(endDateStr[2]);
        int month = int.Parse(endDateStr[1]);
        int year = int.Parse(endDateStr[0]);
 
        // main logic
        DateTime startDay = DateTime.Today;
        DateTime endDay = new DateTime(year, month, day);
        int timeLen = 0;
        timeLen = Math.Abs((endDay - startDay).Days);
        if (startDay > endDay)
        {
            startDay = endDay;
            endDay = DateTime.Today;
        }
 
        // Holydays
        DateTime[] holidays =
        {
            new DateTime(2013, 1, 1),
            new DateTime(2012, 12, 25),
            new DateTime(2012, 5, 24),
            new DateTime(2012, 9, 6),
            new DateTime(2013, 9, 22)
        };
        Console.WriteLine("Time lenght: {0}",timeLen);
        int workDayCounter = 0;
        bool isHoliday = false;
 
        // Day checker
        for (int i = 0; i < timeLen; i++)
        {
            startDay = startDay.AddDays(1);
            if (startDay.DayOfWeek != DayOfWeek.Sunday && startDay.DayOfWeek != DayOfWeek.Saturday)
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (startDay == holidays[j])
                    {
                        isHoliday = true;
                        break;
                    }
                }
 
                if (!isHoliday)
                {
                    workDayCounter++;
                }
 
                isHoliday = false;
            }
        }
 
        Console.WriteLine("Working days: {0}", workDayCounter);
    }
    
}