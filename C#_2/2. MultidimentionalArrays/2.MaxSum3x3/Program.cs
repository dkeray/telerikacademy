using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //Test data
        //int[,] matrix = 
        //    {
        //        {3,4,5,6,7,6,3},
        //        {4,2,7,3,4,4,8},
        //        {3,9,7,5,1,5,3},
        //        {2,5,3,2,5,9,6},
        //        {4,5,6,7,8,1,6},
        //    };
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];

        for (int row = 0; row < m; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("[ {0} , {1} ] = ",row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }   
        }

        int maxsum = 0;
        int maxrow = 0;
        int maxcol = 0;
        for (int row = 0; row < matrix.GetLength(0)-2; row++)
        {
            int sum = 0;
            for (int col = 0; col < matrix.GetLength(1)-2; col++)
            {
                sum = matrix[row,col] + 
                      matrix[row,col+1] + 
                      matrix[row,col+2] + 
                      matrix[row+1,col] + 
                      matrix[row+1,col+1] + 
                      matrix[row+1,col+2] +
                      matrix[row+2,col] + 
                      matrix[row+2,col+1] + 
                      matrix[row+2,col+2];
            
             if (maxsum < sum)
	            {
		             maxsum = sum;
                     maxrow = row;
                     maxcol = col;
	            }
            }
        }

        Console.WriteLine(maxsum);
        for (int i = maxrow; i < maxrow + 3; i++)
        {
            for (int y = maxcol; y < maxcol + 3; y++)
            {
                Console.Write("{0,4}", matrix[i,y]);
            }
            Console.WriteLine();
        }

    }
}