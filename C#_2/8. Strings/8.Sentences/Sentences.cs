using System;

class Program
{

    public static int CountSubstring(string text, string subtr)
    {
        int count = 0;
        text = text.ToLower();
        while (text.IndexOf(subtr) != -1)
        {
            int pos = text.LastIndexOf(subtr);
            if (text.Substring(pos, subtr.Length) != "")
            {
                count++;
                text = text.Remove(pos);
            }
        }
        return count;
    }

    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = " in ";
        string[] sentences = text.Split('.');

        for (int i = 0; i < sentences.Length; i++)
        {
            if (CountSubstring(sentences[i], word) > 0)
            {
                Console.WriteLine((sentences[i] + ".").Trim());
            }
        }
    }
}
