using System;

namespace BankAccounts
{
    class BankAccounts
    {
        static void Main()
        {
            string FirstName = "Deyan";
            string MiddleName = "Rudolf";
            string LastName = "Keray";
            string HolderName = FirstName + MiddleName + LastName;
            double AcouuntBalance = 1090876.67;
            string BankName = "Unicredit Bulbank";
            string IBAN = "BG56 UNCR 1244 2345 2313";
            string BIC = "BGSFUNCR";
            ulong CreditCardVisa = 1234567890123456;
            ulong CreditCardMasterCard = 1234567890000000;
            ulong CreditCardAmericanExpress = 1234567890654321;
            Console.WriteLine(@"
            Holer name:                     {0}
            Account balance:                {1}
            Bank name:                      {2}
            IBAN:                           {3} 
            BIC:                            {4}
            Credit card Visa:               {5} 
            Credit card Master Card:        {6} 
            Credit card American express:   {7} ", 
            HolderName, AcouuntBalance, BankName, IBAN, BIC, CreditCardVisa, CreditCardMasterCard ,CreditCardAmericanExpress );
        }
    }
}