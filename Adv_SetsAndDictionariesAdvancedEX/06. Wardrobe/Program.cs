using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> dict = new();

            for (int i = 0; i < n; i++)
            {
                string[] splitter = Console.ReadLine().Split(" -> ");
                string[] tokens = splitter[1].Split(",");

                string color = splitter[0];

                if (!dict.ContainsKey(color))
                {
                    dict.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < tokens.Length; j++)
                {
                    string currentCloth = tokens[j];
                    if (!dict[color].ContainsKey(currentCloth))
                    {
                        dict[color].Add(currentCloth, 0);
                    }
                    dict[color][currentCloth]++;
                }
            }

            string[] toBeFound = Console.ReadLine().Split();
            string colorToFind = toBeFound[0];
            string chothToFind = toBeFound[1];

            foreach (var choth in dict)
            {
                Console.WriteLine($"{choth.Key} clothes:");
                foreach (var item in choth.Value)
                {
                    if (choth.Key == colorToFind && item.Key == chothToFind)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
