using System;

class ReplaceWords
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] forbidenwords = {"PHP", "CLR", "Microsoft" };
        foreach (var item in forbidenwords)
        {
            text = text.Replace(item, new String('*', item.Length));
        }
        Console.WriteLine(text);
    }
}
