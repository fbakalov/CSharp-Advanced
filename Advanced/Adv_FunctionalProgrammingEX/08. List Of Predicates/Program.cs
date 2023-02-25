using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<Predicate<int>> listOfPredicates = new List<Predicate<int>>();
            foreach (var divider in dividers)
            {
                listOfPredicates.Add(x => x % divider == 0);
            }

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }

            for (int i = 0; i < listOfPredicates.Count; i++)
            {
                numbers = numbers.Where(x => listOfPredicates[i](x)).ToArray();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
