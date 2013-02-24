using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter e bonus score in range [1..9]");
        string choice = Console.ReadLine();
        uint res;
        bool WhatIsChoice = uint.TryParse(choice, out res);
        if (WhatIsChoice == true)
        {
            switch (res)
            {
                case 1 :
                    res *= 10;
                    Console.WriteLine(res);
                    break;
                case 2:
                    res *= 10;
                    Console.WriteLine(res);
                    break;
                case 3:
                    res *= 10;
                    Console.WriteLine(res);
                    break;
                case 4:
                    res *= 100;
                    Console.WriteLine(res);
                    break;
                case 5:
                    res *= 100;
                    Console.WriteLine(res);
                    break;
                case 6:
                    res *= 100;
                    Console.WriteLine(res);
                    break;
                case 7:
                    res *= 1000;
                    Console.WriteLine(res);
                    break;
                case 8:
                    res *= 1000;
                    Console.WriteLine(res);
                    break;
                case 9:
                    res *= 1000;
                    Console.WriteLine(res);
                    break;
                default:
                    Console.WriteLine("Error! Entered bonus score is not is range [1..9].");
                    break;
            }
        }
        else Console.WriteLine("Error! Entered bonus score is not a digit.");
        
    }
}
