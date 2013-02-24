using System;

class Pillars
{
    static void Main()
    {
        int[,] m = new int[8, 8];

        for (int row = 0; row <= 7; row++)
        {
            int temp = int.Parse(Console.ReadLine());
            for (int col = 0; col <= 7; col++)
            {
                m[row, 7 - col] = (temp >> col) & 1;
            }
        }

        //for (int row = 0; row <= 7; row++)
        //{
        //    for (int col = 0; col <= 7; col++)
        //    {
        //        Console.Write(m[row,col]);
        //    }
        //    Console.WriteLine();
        //}

        for (int LineCol = 0; LineCol <= 7; LineCol++)
        {
            int CountLeft = 0, CountRight = 0;
            for (int col = LineCol-1; col >= 0; col--)
            {
                for (int row = 0; row <= 7; row++)
                {
                    if (m[row, col] == 1) CountLeft++;
                }
            }
            for (int col = LineCol+1; col <= 7; col++)
            {
                for (int row = 0; row <= 7; row++)
                {
                    if (m[row, col] == 1) CountRight++;
                }
            }
            if (CountLeft == CountRight)
            {
                Console.WriteLine(7-LineCol);
                Console.WriteLine(CountLeft);
                break;
            }
            if (LineCol == 7)
            {
                Console.WriteLine("No");
            }
        }


    }
}
