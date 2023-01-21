using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = arr[0];
            int m = arr[1];
            HashSet<string> set1 = new HashSet<string>();
            HashSet<string> set2 = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                set1.Add(Console.ReadLine());
            }
            for (int i = 0; i < m; i++)
            {
                set2.Add(Console.ReadLine());
            }

            set1.IntersectWith(set2);
            Console.WriteLine(string.Join(" ", set1));
        }
    }
}
