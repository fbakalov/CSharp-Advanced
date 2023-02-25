using System;
using System.Linq;

namespace _3._Maximal_Sum
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

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(input[col]);
                }
            }

            int biggestSum = 0;
            int biggestRow = 0, biggestCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row < matrix.GetLength(0) - 2 && col < matrix.GetLength(1) - 2)
                    {
                        int currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                      matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                      matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                        if (currSum > biggestSum)
                        {
                            biggestSum = currSum;
                            biggestRow = row;
                            biggestCol = col;
                        }
                    }
                }
            }
            Console.WriteLine("Sum = " + biggestSum);
            for (int row = biggestRow; row < biggestRow + 3; row++)
            {
                for (int col = biggestCol; col < biggestCol + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
