using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Predicate<string>> filters = new();

            List<string> names = Console.ReadLine()
                .Split()
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "Print")
            {
                string[] tokens = input.Split(";");
                string firstArg = tokens[1];
                string secondArg = tokens[2];
                if (tokens[0] == "Add filter")
                {
                    filters.Add(firstArg + secondArg, GetPredicate(firstArg, secondArg));
                }
                else if (tokens[0] == "Remove filter")
                {
                    filters.Remove(firstArg + secondArg);
                }
            }

            foreach (var filter in filters)
            {
                names.RemoveAll(filter.Value);
            }
            Console.WriteLine(string.Join(" ", names));
        }

        private static Predicate<string> GetPredicate(string firstArg, string secondArg)
        {
            switch (firstArg)
            {
                case "Starts with":
                    return n => n.StartsWith(secondArg);
                case "Ends with":
                    return n => n.EndsWith(secondArg);
                case "Length":
                    return n => n.Length == int.Parse(secondArg);
                case "Contains":
                    return n => n.Contains(secondArg);
                default:
                    return null;
            }
        }
    }
}
