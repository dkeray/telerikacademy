using System;

class ShowSign
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        int counter = 0;
        if (a < 0)
        {
            counter++;
        }
        if (b < 0)
        {
            counter++;
        }
        if (c < 0)
        {
            counter++;
        }
        if (counter == 1 || counter == 3)
        {
            Console.WriteLine("The sign of product is -");            
        }
        else Console.WriteLine("The sign of product is +");

    }
}