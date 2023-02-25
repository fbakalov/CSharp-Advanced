using System;
using System.Linq;

namespace _09._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            string[] commands = Console.ReadLine().Split();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = char.Parse(input[col]);
                }
            }

            int rowMiner = 0;
            int colMiner = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 's')
                    {
                        rowMiner = row;
                        colMiner = col;
                        break;
                    }
                }
            }

            
            foreach (string command in commands)
            {                
                if (command == "left")
                {
                    if (colMiner - 1 < matrix.GetLength(1) && colMiner - 1 >= 0)
                    {
                        colMiner -= 1;
                    }
                }
                if (command == "right")
                {
                    if (colMiner + 1 < matrix.GetLength(1) && colMiner + 1 >= 0)
                    {
                        colMiner += 1;
                    }
                }
                if (command == "up")
                {
                    if (rowMiner - 1 < matrix.GetLength(0) && rowMiner - 1 >= 0)
                    {
                        rowMiner -= 1;
                    }
                }
                if (command == "down")
                {
                    if (rowMiner + 1 < matrix.GetLength(0) && rowMiner + 1 >= 0)
                    {
                        rowMiner += 1;
                    }
                }

                if (matrix[rowMiner, colMiner] == 'e')
                {
                    Console.WriteLine($"Game over! ({rowMiner}, {colMiner})");
                    return;                   
                }

                if (matrix[rowMiner, colMiner] == 'c')
                {
                    matrix[rowMiner, colMiner] = '*';
                }
            }

            int count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'c')
                    {
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"You collected all coals! ({rowMiner}, {colMiner})");
            }
            else
            {
                Console.WriteLine($"{count} coals left. ({rowMiner}, {colMiner})");
            }
        }
    }
}
