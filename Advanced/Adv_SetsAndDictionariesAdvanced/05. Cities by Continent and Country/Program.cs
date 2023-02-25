using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> nana = new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string enter = Console.ReadLine();
                string[] arguments = enter.Split();
                string continent = arguments[0];
                string country = arguments[1];
                string city = arguments[2];

                if (!nana.ContainsKey(continent))
                {
                    nana.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!nana[continent].ContainsKey(country))
                {
                    nana[continent].Add(country, new List<string>());

                }

                nana[continent][country].Add(city);
            }

            foreach (var item in nana)
            {
                Console.WriteLine(item.Key + ":");

                foreach (var item2 in item.Value)
                {
                    Console.WriteLine("  " + item2.Key + " -> " + string.Join(", ", item2.Value));
                    
                }
            }
        }
    }
}
