using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> uniqe = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < input.Length; j++)
                {
                    uniqe.Add(input[j]);
                }
            }

            uniqe = uniqe.OrderBy(x => x).ToHashSet();
            Console.WriteLine(string.Join(" ", uniqe));

        }
    }
}
