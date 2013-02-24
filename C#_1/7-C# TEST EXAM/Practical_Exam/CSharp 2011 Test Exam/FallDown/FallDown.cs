using System;

class FallDawn
{
    static void Main()
    {
        int[,] m = new int[8, 8];
        for (int row = 0; row <= 7; row++)
        {
            int temp = int.Parse(Console.ReadLine());
            for (int col = 0; col <=7; col++)
            {
                m[row, 7-col] = (temp >> col) & 1;
            }            
        }

        for (int i = 0; i <= 7; i++)
        {
            int countOnes = 0;
            for (int pos = 0; pos <= 7; pos++)
            {
                if (m[pos,i] == 1) countOnes++;

            }
            for (int pos = 0; pos <= 7 ; pos++)
            {
                if (pos <= (7 - countOnes))
                {
                    m[pos, i] = 0;
                }
                else m[pos, i] = 1;
            }
           
        }
        for (int row = 0; row <= 7; row++)
        {
            int temp = 1;
            for (int col = 0; col <= 7; col++)
            {
                if (m[row,7-col] == 1) temp = temp | (1 << col);
                else temp = temp & ~(1 << col);
            }
            Console.WriteLine(temp);
        }
    }
}
