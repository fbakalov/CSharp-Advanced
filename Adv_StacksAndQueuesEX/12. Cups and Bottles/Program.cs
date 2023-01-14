using System;
using System.Linq;
using System.Collections.Generic;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> bottles = new(Console.ReadLine().Split().Select(int.Parse));

            int wastedWater = 0;

            while (cups.Any() && bottles.Any())
            {
                int currCup = cups.Peek();
                int currBottle = bottles.Peek();

                if (currBottle >= currCup)
                {
                    wastedWater += currBottle - currCup;
                    cups.Dequeue();
                    bottles.Pop();
                }
                else
                {
                    while (currCup > 0)
                    {
                        if (currBottle >= currCup)
                        {
                            wastedWater += currBottle - currCup;
                            cups.Dequeue();
                            bottles.Pop();
                            currCup = 0;
                        }
                        else
                        {
                            currCup -= currBottle;
                            bottles.Pop();
                            currBottle = bottles.Peek();
                        }                    
                    }
                }
            }

            if (cups.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
