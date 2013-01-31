using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Short
{

    static void Main()
    {
        Console.WriteLine("Enter your short number = ");
        short number = short.Parse(Console.ReadLine());
        short sing = number;

        if (sing <= 0) { number = (short)(number + 1); }

        for (int i = 15; i >= 0; i--)
        {
            short stepen = (short)Math.Pow(2, i);
            short digit = (short)(number / stepen);
            number = (short)(number % stepen);

            if (sing < 0) { Console.Write(1 + digit); }
            else { Console.Write(digit); }
        }
        Console.WriteLine();
    }
}