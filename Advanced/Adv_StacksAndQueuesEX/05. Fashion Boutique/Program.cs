using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new(
                Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
            );

            int rackSize = int.Parse(Console.ReadLine());

            int currentRackSize = rackSize;
            int numberOfRacks = 1;

            while (clothes.Any())
            {
                currentRackSize -= clothes.Peek();

                if (currentRackSize < 0)
                {
                    currentRackSize = rackSize;
                    numberOfRacks++;

                    continue;
                }
                clothes.Pop();
            }
            Console.WriteLine(numberOfRacks);
        }
    }
}
