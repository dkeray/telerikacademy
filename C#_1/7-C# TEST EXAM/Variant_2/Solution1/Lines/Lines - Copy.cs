using System;

class Lines
{
    static void Main()
    {
        int[,] m = new int[8, 8];
        for (int row = 0; row <= 7; row++)
        {
            int readInt = int.Parse(Console.ReadLine());
            for (int col = 0; col <= 7; col++)
            {
                m[row, 7 - col] = (readInt >> col) & 1;
            }
        }

        for (int row = 0; row <= 7; row++)
        {
            for (int col = 0; col <= 7; col++)
            {
                Console.Write(m[row, col]);
            }
            Console.WriteLine();
        }

        int maxDots = 0;
        int maxLines = 0;
        int tempLines = 0;
        for (int row = 0; row <= 7; row++)
        {
            int tempdots = 0;
            for (int col = 0; col <= 7; col++)
            {
                if (m[row, col] == 0) { tempdots = 0; if (tempLines != 0) tempLines++; }
                if (m[row,col] == 1)
                {
                    if ((col != 0) && (m[row, col - 1] == 1)) tempdots++;
                    if (tempdots == 0) tempdots++; 
        
                }
            }
            if (maxDots < tempdots)
            {
                maxDots = tempdots;
                maxLines = 0;
            }
            if (maxDots == tempdots && maxDots !=0)
            {
                maxDots = tempdots;
                maxLines+=tempLines;
            }
        }

        for (int col = 0; col <= 7; col++)
        {
            int tempdots = 0;
            for (int row = 0; row <= 7; row++)
            {
                if (m[row, col] == 0) { tempdots = 0; if (tempLines != 0) tempLines++; }
                if (m[row, col] == 1)
                {
                    if (row != 0) if (m[row-1, col] == 1) tempdots++;
                    if (tempdots == 0) tempdots++; 
                }
            }
            if (maxDots < tempdots)
            {
                maxDots = tempdots;
                maxLines = 0;
            }
            if (maxDots == tempdots && maxDots != 0)
            {
                maxDots = tempdots;
                maxLines += tempLines;
            }
        }


        Console.WriteLine(maxDots);
        Console.WriteLine(maxLines);

    }
}
