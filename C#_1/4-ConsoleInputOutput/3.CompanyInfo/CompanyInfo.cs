using System;

class CompanyInfo
{
    static void Main()
    {
        Console.Write("Enter Company name: ");
        string CompanyName = Console.ReadLine();
        Console.Write("Enter Company address: ");
        string CompanyAddress = Console.ReadLine();
        Console.Write("Enter Company phone: +359");
        string CompanyPhone = Console.ReadLine();
        Console.Write("Enter Company fax: +359");
        string CompanyFax = Console.ReadLine();
        Console.Write("Enter Company website: http://www.");
        string CompanyWebSite = Console.ReadLine();
        Console.Write("Enter Manager First Name: ");
        string ManagerFirstName = Console.ReadLine();
        Console.Write("Enter Manager Last name: ");
        string ManagerLastName = Console.ReadLine();
        Console.Write("Enter Manager Age: ");
        byte ManagerAge = byte.Parse(Console.ReadLine());
        Console.Write("Enter Manager Phone: +359");
        string ManagerPhone = Console.ReadLine();

        Console.WriteLine("\n\n\r");

        Console.WriteLine("Company name: " + CompanyName);
        Console.WriteLine("Company address: " + CompanyAddress);
        Console.WriteLine("Company phone: +359" + CompanyPhone);
        Console.WriteLine("Company fax: +359" + CompanyFax);
        Console.WriteLine("Company website: http://www." + CompanyWebSite);
        Console.WriteLine("Manager First Name: " + ManagerFirstName);
        Console.WriteLine("Manager Last Name: " + ManagerLastName);
        Console.WriteLine("Manager Age: " + ManagerAge);
        Console.WriteLine("manager phone: +359" + ManagerPhone);
    }
}
