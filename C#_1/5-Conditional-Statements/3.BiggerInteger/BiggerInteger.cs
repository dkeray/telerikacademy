using System;

class BiggerInteger
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        
        if (a >= b)
        {
            if (a >= c)
            {
                Console.WriteLine("Biggest nunmer is {0}", a);
            }
            else if (c >= a)
                {
                 Console.WriteLine("Biggest nunmer is {0}", b);   
                }
            
        }
        else if (b >= c)
            {
                Console.WriteLine("Biggest nunmer is {0}", b);
            }
            else if (b <= c)
                {
                    Console.WriteLine("Biggest nunmer is {0}", c);
                }        
    }
}