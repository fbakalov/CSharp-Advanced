using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int lower = range[0];
            int upper = range[1];

            List<int> numbers = new List<int>();
            for (int i = lower; i <= upper; i++)
            {
                numbers.Add(i);
            }

            string command = Console.ReadLine();
            Predicate<int> predicate = EvenOrOdd(command);

            static Predicate<int> EvenOrOdd(string command)
            {
                if (command == "even")
                {
                    return x => x % 2 == 0;
                }
                else if (command == "odd")
                {
                    return x => x % 2 != 0;
                }
                return null;
            }


            numbers = numbers.Where(x => predicate(x)).ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
