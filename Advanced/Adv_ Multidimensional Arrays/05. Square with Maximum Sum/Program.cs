using System;
using System.Linq;

namespace _05._Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
               .Split(", ")
               .Select(int.Parse)
               .ToArray();

            int[,] matrix = new int[input[0], input[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int maxSum = 0;
            int maxRow = 0;
            int maxCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {          
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int currSum = 0;
                    if (row >= matrix.GetLength(0) - 1 || col >= matrix.GetLength(1) - 1)
                    {
                        continue;
                    }
                    currSum += matrix[row, col];
                    currSum += matrix[row + 1, col];
                    currSum += matrix[row, col + 1];
                    currSum += matrix[row + 1, col + 1];

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol + 1]} {matrix[maxRow, maxCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
