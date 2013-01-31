using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class MatrixFile
{
    static void Main()
    {
        string p = @"..\..\..\tests\matrix.txt";
        StreamReader reader = new StreamReader(p);

        int lineNumber = 0;
        int n = int.Parse(reader.ReadLine());
        int[,] matrix = new int[n, n];

        for (int row = 0; row < n; row++)
        {
            string[] numbers = reader.ReadLine().Split(' ');
            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = int.Parse(numbers[col]);
            }
        }
        reader.Close();
         
        int sum = 0;
        for (int row = 0; row < n-1; row++)
        {
            for (int col = 0; col < n-1; col++)
            {
                int temp = matrix[row, col] + matrix[row+1, col] + matrix[row, col+1] + matrix[row+1, col+1];
                if (sum < temp)
                {
                    sum = temp;                    
                }
            }
        }

        Console.WriteLine("Maximal sum is {0}.", sum);



        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(matrix[row,col] + " ");
            }
            Console.WriteLine();
        }

    }
}
