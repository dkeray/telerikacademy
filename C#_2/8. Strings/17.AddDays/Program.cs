﻿using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string start = "27.02.2006 20:00:00";

        DateTime startDate = DateTime.ParseExact(start, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        startDate = startDate.AddHours(6.5);
        Console.WriteLine("{0} {1}", startDate.ToString("dddd",new CultureInfo("bg-BG")), startDate );
    }
}