using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EnterNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        try
        {
            uint num = uint.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(num));
            return; // Exit from the current method
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }

    }   
}