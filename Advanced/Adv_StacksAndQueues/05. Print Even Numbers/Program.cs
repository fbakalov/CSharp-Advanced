using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> que = new Queue<int>();
            foreach (var item in arr)
            {
                que.Enqueue(item);
            }

            List<int> newL = new List<int>();
            while (que.Count > 0)
            {
                int num = que.Dequeue();
                if (num % 2 == 0)
                {
                    newL.Add(num);
                }
            }
            Console.WriteLine(string.Join(", ", newL));
        }
    }
}
