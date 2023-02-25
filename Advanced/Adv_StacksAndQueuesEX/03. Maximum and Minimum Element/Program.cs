using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new();

            for (int i = 0; i < n; i++)
            {
                int[] tokens = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int querie = tokens[0];

                if (querie == 1)
                {
                    stack.Push(tokens[1]);
                }
                if (querie == 2)
                {
                    if (stack.Any())
                    {
                        stack.Pop();
                    }                  
                }
                if (querie == 3)
                {
                    if (stack.Any())
                    {
                        Console.WriteLine(stack.Max());
                    }                   
                }
                if (querie == 4)
                {
                    if (stack.Any())
                    {
                        Console.WriteLine(stack.Min());
                    }                  
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
