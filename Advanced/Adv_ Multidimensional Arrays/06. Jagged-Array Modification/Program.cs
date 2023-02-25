using System;
using System.Linq;

namespace _06._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jaggedArr = new int[n][];

            for (int row = 0; row < jaggedArr.Length; row++)
            {
                string[] nums = Console.ReadLine().Split();
                jaggedArr[row] = new int[nums.Length];
                for (int col = 0; col < jaggedArr.Length; col++)
                {
                    jaggedArr[row][col] = int.Parse(nums[col]);
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmd = command.Split();
                int row = int.Parse(cmd[1]);
                int col = int.Parse(cmd[2]);
                int value = int.Parse(cmd[3]);
                
                if (row < 0 || col < 0 || row >= jaggedArr.Length || col >= jaggedArr[row].Length                    )
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {               
                    if (cmd[0] == "Add")
                    {
                        jaggedArr[row][col] += value;
                    }
                    else if (cmd[0] == "Subtract")
                    {
                        jaggedArr[row][col] -= value;
                    }
                }
                
            }

            for (int row = 0; row < jaggedArr.Length; row++)
            {
                for (int col = 0; col < jaggedArr[row].Length; col++)
                {
                    Console.Write(jaggedArr[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
