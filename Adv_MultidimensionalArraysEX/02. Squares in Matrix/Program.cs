using System;
using System.Linq;

namespace _02._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rows = parameters[0];
            int cols = parameters[1];

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = char.Parse(input[col]);
                }
            }

            int count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row != matrix.GetLength(0) - 1 && col != matrix.GetLength(1) - 1)
                    {
                        char symbol = matrix[row, col];
                        if (symbol == matrix[row, col + 1] && symbol == matrix[row + 1, col] && symbol == matrix[row + 1, col + 1])
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
