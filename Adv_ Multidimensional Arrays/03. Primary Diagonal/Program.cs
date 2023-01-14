using System;
using System.Linq;

namespace _03._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int sumDiagonal = 0;
            int row2 = 0;
            int col2 = 0;

            while (row2 < matrix.GetLength(0) && col2 < matrix.GetLength(1))
            {
                sumDiagonal += matrix[row2, col2];
                row2++;
                col2++;
            }

            Console.WriteLine(sumDiagonal);
        }
    }
}
