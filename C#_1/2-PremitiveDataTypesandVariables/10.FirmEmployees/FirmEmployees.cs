using System;
namespace FirmEmployees
{
    class FirmEmployees
    {
        static void Main()
        {
            string FirstName = "Deyan";
            string FamilyName = "Keray";
            byte Age = 31;
            bool isMale = true;
            uint IDNumber = 1567;
            uint UniEmpNum = 27560001;
            string text = "The name of employee is " + FirstName + " " + FamilyName + " is " + Age + " old and is a male " + isMale + " with ID " + IDNumber + " and Unique employee number is " + UniEmpNum;
            Console.WriteLine(text);
        }
    }
}