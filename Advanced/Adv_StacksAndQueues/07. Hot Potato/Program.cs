using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(children);

            int n = int.Parse(Console.ReadLine());
            int toses = 1;
            while (queue.Count != 1)
            {
                string child = queue.Dequeue();
                if (toses < n)
                {
                    toses++;
                    queue.Enqueue(child);
                }
                else
                {
                    Console.WriteLine($"Removed {child}");
                    toses = 1;
                }
                
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
