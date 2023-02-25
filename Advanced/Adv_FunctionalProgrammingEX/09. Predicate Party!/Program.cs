using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();



            string input;
            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                string filterType = tokens[1];

                Func<string, string, bool> func = GetFilterType(filterType);
                if (command == "Remove")
                {
                    names = names.Where(n => !func(n, tokens[2])).ToList();
                }
                else if (command == "Double")
                {
                    List<string> namesMatchingCondition = names.Where(n => func(n, tokens[2])).ToList();
                    foreach (var name in namesMatchingCondition)
                    {
                        int index = names.FindIndex(n => n == name);
                        names.Insert(index, name);
                    }
                }
            }
            if (names.Any())
            {
                Console.WriteLine(string.Join(", ", names) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static Func<string, string, bool> GetFilterType(string filterType)
        {
            if (filterType == "StartsWith")
            {
                return (n, str) => n.StartsWith(str);
            }
            else if (filterType == "EndsWith")
            {
                return (n, str) => n.EndsWith(str);
            }
            else if (filterType == "Length")
            {
                return (n, length) => n.Length == int.Parse(length);
            }
            return null;
        }
    }
}
