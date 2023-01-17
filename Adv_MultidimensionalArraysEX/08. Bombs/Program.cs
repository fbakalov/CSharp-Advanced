using System;
using System.Linq;

namespace _08._Bombs
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

            string[] bombs = Console.ReadLine().Split();
            for (int i = 0; i < bombs.Length; i++)
            {
                int[] coordinates = bombs[i].Split(",").Select(int.Parse).ToArray();
                int bombRow = coordinates[0];
                int bombCol = coordinates[1];
                int bombValue = matrix[bombRow, bombCol];
                matrix[bombRow, bombCol] = 0;

                for (int row = bombRow - 1; row <= bombRow + 1; row++)
                {
                    for (int col = bombCol - 1; col <= bombCol + 1; col++)
                    {
                        if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
                        {
                            if (matrix[row, col] <= 0 || bombValue < 0)
                            {
                                continue;
                            }
                            matrix[row, col] -= bombValue;
                        }
                    }
                }   
            }        

            int sum = 0;
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        count++;
                        sum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
