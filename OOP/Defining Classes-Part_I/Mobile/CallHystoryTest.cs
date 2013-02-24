using System;
using System.Collections.Generic;
using System.Text;

class CallHistoryTest
{
    // Private Fields
    private readonly CallHistory callHistory = null;

    // Constructors
    public CallHistoryTest(CallHistory callHistory)
    {
        this.callHistory = callHistory;
    }

    // Methods
    public void GetPrice(decimal price)
    {
        StringBuilder info = new StringBuilder();

        info.Append(String.Format("Minutes: {0}", this.callHistory.GetStartedMinutes()) + "\n");
        info.Append(String.Format("Price {0}: {1}", price, this.callHistory.CalculatePrice(price)));

        Console.WriteLine("Calculating price" + info.ToString());

    }

    public void Remove(int id)
    {
        StringBuilder info = new StringBuilder();

        info.Append(String.Format("Removed: {0}", this.callHistory.Get(id).ToString()) + "\n");
        this.callHistory.Remove(id);

        info.Append("Remaining:");
        info.Append(this.callHistory.ToString() + "\n");

        Console.WriteLine("Removing a call ID" + info.ToString());
    }

    public void RemoveLongestCall()
    {
        Call longestCall = this.callHistory.Max();

        this.callHistory.Remove(longestCall.Id);

        Console.WriteLine("Remove longest call" + longestCall.ToString());
    }

    public void ClearHistory()
    {
        this.callHistory.Clear();

        Console.WriteLine("Clear history" + this.callHistory.ToString());
    }
}