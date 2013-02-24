using System;

class UserChoice
{
    static void Main()
    {
    
    //  Variant 1
        string choice = Console.ReadLine();
        double res;
        bool WhatIsChoice = double.TryParse(choice, out res);
        switch (WhatIsChoice)
        {
            case true:
                Console.WriteLine(res + 1);
                break;
            case false:
                Console.WriteLine("{0}*", choice);
                break;
            default:
                Console.WriteLine("Opaaa!");
                break;
        }

    //  Variant 2
    //    Console.Write("Enter your choice 1-Int, 2-Double, 3-String: ");
    //    int choice = int.Parse(Console.ReadLine());
       
    //    switch (choice)
    //    {
    //        case 1:
    //            Console.Write("Enter Int number: ");
    //            int a = int.Parse(Console.ReadLine());
    //            a++;
    //            Console.WriteLine("Increesed number +1 -> {0}",a);
    //            break;
    //        case 2:
    //            Console.Write("Enter Double number: ");
    //            double b = double.Parse(Console.ReadLine());
    //            b++;
    //            Console.WriteLine("Increesed number +1 -> {0}", b);
    //            break;
    //        case 3:
    //            Console.Write("Enter String number: ");
    //            string c = Console.ReadLine();
    //            c = c + "*";
    //            Console.WriteLine("String is -> {0}", c);
    //            break;
    //        default:
    //            Console.WriteLine("There is no such choice! Try again!");
    //            break;
    //    }
    
    
    }
}