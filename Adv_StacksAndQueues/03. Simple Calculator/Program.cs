using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split()
                .ToArray();
            
            Stack<string> stack = new Stack<string>();
            foreach (string item in arr.Reverse())
            {
                stack.Push(item);
            }

            int sum = int.Parse(stack.Pop());
            while (stack.Count > 0)
            {
                string operation = stack.Pop();

                int n2 = int.Parse(stack.Pop());
                if (operation == "+")
                {
                    sum += n2;
                }
                else if (operation == "-")
                {
                    sum -= n2;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
