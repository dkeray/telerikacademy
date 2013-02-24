using System;

class AstrologicalDigits
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());



        do
        {
            string stringN = Convert.ToString(n);
            ulong sum = 0;
            for (int i = 0; i < stringN.Length; i++)
            {
                if (stringN[i] >= '0' && stringN[i] <= '9')
                {
                    sum += (ulong)(stringN[i] - '0');
                }
            }

            n = sum;
        }
        while (n > 9);
        Console.WriteLine(n);   
    }
}
