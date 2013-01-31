using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Test data
        int[,] matrix = 
            {
                {3,5,5,3},
                {1,3,3,3},
                {5,3,3,3},
                {2,4,1,3},
                {1,5,3,3},
            };
        
        int lenghtcol = matrix.GetLength(1);
        int lenghtrow = matrix.GetLength(0);

        int MaxSequence = 0;
        int SequenceNum = 0;
        // searching in row

        for (int row = 0; row < lenghtrow; row++)
        {
            int sum = 0;
            for (int col = 0; col < lenghtcol - 1; col++)
            {

                if (matrix[row, col] == matrix[row, col + 1])
                {
                    sum++;
                }
                if (MaxSequence < sum)
                {
                    MaxSequence = sum;
                    SequenceNum = matrix[row, col];
                }
            }
        }

        // searching in col
        for (int col = 0; col < lenghtcol - 1; col++)
        {
            int sum = 0;
            for (int row = 0; row < lenghtrow; row++)
            {

                if (matrix[row, col] == matrix[row, col + 1])
                {
                    sum++;
                }
                if (MaxSequence < sum)
                {
                    MaxSequence = sum;
                    SequenceNum = matrix[row, col];
                }
            }
        }

        // searching in diagonal
        for (int i = 0; i < lenghtrow; i++)
        {
            int row = i;
            int col = 0;
            int sum = 0;
            while (row < lenghtrow - 1 && col < lenghtcol - 1)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    sum++;
                }
                row++;
                col++;
                if (MaxSequence < sum)
                {
                    MaxSequence = sum;
                    SequenceNum = matrix[row, col];
                }
            }
        }
        for (int i = 0; i < lenghtcol; i++)
        {
            int row = 0;
            int col = i;
            int sum = 0;
            while (row < lenghtrow - 1 && col < lenghtcol - 1)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    sum++;
                }
                row++;
                col++;
                if (MaxSequence < sum)
                {
                    MaxSequence = sum;
                    SequenceNum = matrix[row, col];
                }
            }
        }

        for (int i = 0; i < lenghtrow; i++)
        {
            int row = i;
            int col = lenghtcol - 1;
            int sum = 0;
            while (row < lenghtrow - 1 && col > 0)
            {
                if (matrix[row, col] == matrix[row + 1, col - 1])
                {
                    sum++;
                }
                row++;
                col--;
                if (MaxSequence < sum)
                {
                    MaxSequence = sum;
                    SequenceNum = matrix[row, col];
                }
            }
        }
        for (int i = lenghtcol - 1; i > 0; i--)
        {
            int row = 0;
            int col = i;
            int sum = 0;
            while (row < lenghtrow - 1 && col > 0)
            {
                if (matrix[row, col] == matrix[row + 1, col - 1])
                {
                    sum++;
                }
                row++;
                col--;
                if (MaxSequence < sum)
                {
                    MaxSequence = sum;
                    SequenceNum = matrix[row, col];
                }
            }
        }

        //print result
        MaxSequence++;
        Console.Write(MaxSequence + " --> ");
        for (int i = 0; i < MaxSequence; i++)
        {
            Console.Write(SequenceNum + ", ");
        }
        Console.WriteLine();

    }
}