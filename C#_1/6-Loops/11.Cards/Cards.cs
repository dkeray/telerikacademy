using System;

class Cards
{
    static void Main()
    {
        string num = "";
        //for (int i = 1; i <=4; i++)
        //{
        //    switch (i)
        //    {
        //        case 1: card = "Clubs"; break;
        //        case 2: card = "Diamonds"; break;
        //        case 3: card = "Hearts"; break;
        //        case 4: card = "Spades"; break;
        //        default: card = ""; break;
        //    }
            for (int y = 0; y <= 13; y++)
            {
                switch (y)
                {
                    case 0: num = "Ace"; break;
                    case 1: num = "1"; break;
                    case 2: num = "2"; break;
                    case 3: num = "3"; break;
                    case 4: num = "4"; break;
                    case 5: num = "5"; break;
                    case 6: num = "6"; break;
                    case 7: num = "7"; break;
                    case 8: num = "8"; break;
                    case 9: num = "9"; break;
                    case 10: num = "10"; break;
                    case 11: num = "Jack"; break;
                    case 12: num = "Queen"; break;
                    case 13: num = "King"; break;
                  
                }
//                Console.WriteLine("{0,10} of {1}",num, card);
                Console.WriteLine("{0,10} of Clubes {0,10} of Diamonds {0,10} of Hearts {0,10} of Spades ", num);
            }
        //}
    }
}