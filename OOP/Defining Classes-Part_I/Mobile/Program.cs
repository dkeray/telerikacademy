﻿using System;

class Program
{
    static void Main()
    {
        decimal price = .37M;

        Gsm[] gsms = new Gsm[2];

        // GSM 0
        {
            gsms[0] = Gsm.IPhone4S;
        }

        // GSM 1
        {
            Display display = new Display(480, 900, 65000);
            Battery battery = new Battery(Battery.Type.LiIon, 50, 10);

            gsms[1] = new Gsm("Desire", "Htc", "Dido", 345.54m, display, battery);

            gsms[1].CallHistory.Add(new Call("234234", new TimeSpan(1, 7, 10))); // Hours, Minutes, Seconds
            gsms[1].CallHistory.Add(new Call("234142", new TimeSpan(0, 4, 20)));
            gsms[1].CallHistory.Add(new Call("2314234", new TimeSpan(1, 4, 0)));
            gsms[1].CallHistory.Add(new Call("42314256", new TimeSpan(0, 1, 20)));
        }

        // Print
        Console.WriteLine(gsms[0].ToString());
        Console.WriteLine();
        Console.WriteLine(gsms[1].ToString());
        Console.WriteLine();

        // CALL TEST
        CallHistoryTest callHistoryTest = new CallHistoryTest(gsms[1].CallHistory);

        // Calculate price
        callHistoryTest.GetPrice(price);

        // Remove call
        callHistoryTest.Remove(id: 2);

        // Calculate price
        callHistoryTest.GetPrice(price);

        // Remove longest call
        callHistoryTest.RemoveLongestCall();

        // Calculate price
        callHistoryTest.GetPrice(price);

        // Clear call history
        callHistoryTest.ClearHistory();
    }
}