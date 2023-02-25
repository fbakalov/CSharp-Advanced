using System;

namespace _06._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jagged = new int[n][];

            for (int row = 0; row < jagged.Length; row++)
            {
                string[] input = Console.ReadLine().Split();
                jagged[row] = new int[input.Length];
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = int.Parse(input[col]);
                }
            }

            for (int row = 0; row < jagged.Length; row++)
            {
                if (row < jagged.Length - 1)
                {
                    if (jagged[row].Length == jagged[row + 1].Length)
                    {
                        for (int col = 0; col < jagged[row].Length; col++)
                        {
                            jagged[row][col] *= 2;
                            jagged[row + 1][col] *= 2;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < jagged[row].Length; i++)
                        {
                            jagged[row][i] /= 2;
                        }
                        for (int j = 0; j < jagged[row + 1].Length; j++)
                        {
                            jagged[row + 1][j] /= 2;
                        }
                    }
                }                
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split();
                if (arguments.Length != 4)
                {
                    continue;
                }
                int rowToEdit = int.Parse(arguments[1]);
                int colToEdit = int.Parse(arguments[2]);
                int value = int.Parse(arguments[3]);
                if (rowToEdit < 0 || colToEdit < 0)
                {
                    continue;
                }
                if (rowToEdit >= jagged.Length || colToEdit >= jagged[rowToEdit].Length)
                {
                    continue;
                }
                else
                {
                    if (arguments[0] == "Add")
                    {
                        jagged[rowToEdit][colToEdit] += value;
                    }
                    else if (arguments[0] == "Subtract")
                    {
                        jagged[rowToEdit][colToEdit] -= value;
                    }
                }
                
            }

            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
