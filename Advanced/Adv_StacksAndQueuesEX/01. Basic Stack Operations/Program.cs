using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int N = inputs[0];
            int S = inputs[1];
            int X = inputs[2];

            Stack<int> stack = new Stack<int>();

            int[] tokens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            foreach (var item in tokens)
            {
                stack.Push(item);
            }

            for (int i = 0; i < S; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}
