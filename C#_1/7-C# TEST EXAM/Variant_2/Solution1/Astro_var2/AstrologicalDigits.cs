using System;

class Variant2
{
    static void Main()
    {
        int readCH = 0;
        int sum = 0;
        while (true)
        {
            readCH = Console.Read();
     //       Console.Write(Convert.ToChar(readCH));
            if (readCH == 10)
            {
                break;
            }
            if (readCH >= '0' && readCH <= '9')
            {
                sum = sum + ((int)readCH - (int)'0');
            }
        }
       // Console.WriteLine(sum);
        while (sum > 9)
        {
            int help = 0;
            int middlesum = 0;
            while (sum > 0)
            {
                help = sum % 10;
                middlesum += help;
                sum /= 10;

            }
            sum = middlesum;
        }
        Console.WriteLine(sum);
    }
}

