using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();
            foreach (var item in arr)
            {
                stack.Push(item);
            }

            string command;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] splitedCommands = command.Split();
                if (splitedCommands[0] == "add")
                {
                    int first = int.Parse(splitedCommands[1]);
                    int second = int.Parse(splitedCommands[2]);

                    stack.Push(first);
                    stack.Push(second);
                }
                if (splitedCommands[0] == "remove")
                {
                    int n = int.Parse(splitedCommands[1]);
                    if (n <= stack.Count)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                
                }
            }

            Console.WriteLine("Sum: " + stack.Sum());
        }
    }
}
