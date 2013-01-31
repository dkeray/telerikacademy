using System;

class ReadNumberClass
{

    public static void ReadNumber(int start, int end)
    {
        for (int i = 0; i < 10; i++)
        {
            int temp = 0; 
            try
            {
                temp = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                throw new System.FormatException("You should enter integer number!");
            }
            if (temp < start || end > 100)
            {
                throw new System.ArgumentOutOfRangeException("You should enter integer in range 0 < i < 100 ");
            }
            

        }
    }

    static void Main()
    {
        try
        {
            ReadNumber(1, 100);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
            
        }
        catch (FormatException ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);

        }
    }
}
