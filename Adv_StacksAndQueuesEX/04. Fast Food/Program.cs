using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodAmount = int.Parse(Console.ReadLine());
            Queue<int> orders = new(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray()
                );

            int biggestOrder = orders.Max();

            while (orders.Count != 0)
            {
                if (foodAmount >= orders.Peek())
                {
                    foodAmount -= orders.Peek();
                    orders.Dequeue();
                }
                else
                {
                    Console.WriteLine(biggestOrder);
                    Console.WriteLine("Orders left: " + string.Join(" ", orders));
                    return;
                }
            }
            Console.WriteLine(biggestOrder);
            Console.WriteLine("Orders complete");
        }
    }
}
