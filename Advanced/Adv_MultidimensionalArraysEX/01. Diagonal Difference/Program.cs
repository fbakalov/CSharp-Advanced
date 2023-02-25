using System;

namespace _01._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

                     
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(input[col]);
                }
            }

            int sumOfPrimary = 0;
            for (int i = 0; i < n; i++)
            {
                sumOfPrimary += matrix[i, i];
            }
            int sumOfSecondary = 0;

            int ROW = 0;
            int COL = matrix.GetLength(1) - 1;
            while (ROW <= matrix.GetLength(0) && COL >= 0)
            {
                sumOfSecondary += matrix[ROW, COL];
                ROW++;
                COL--;
            }

            Console.WriteLine(Math.Abs(sumOfPrimary - sumOfSecondary));
        }
    }
}
