using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> dict = new();

            string input;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] tokens = input.Split();

                string vloggerName = tokens[0];
                if (tokens[1] == "joined")
                {
                    if (!dict.ContainsKey(vloggerName))
                    {
                        dict.Add(vloggerName, new Dictionary<string, HashSet<string>>());
                        dict[vloggerName].Add("followers", new HashSet<string>());
                        dict[vloggerName].Add("following", new HashSet<string>());
                    }
                }
                else if (tokens[1] == "followed")
                {
                    string vloggerToFollow = tokens[2];

                    if (vloggerName != vloggerToFollow && dict.ContainsKey(vloggerName) && dict.ContainsKey(vloggerToFollow) && !dict[vloggerName]["following"].Contains(vloggerToFollow))
                    {
                        dict[vloggerName]["following"].Add(vloggerToFollow);
                        dict[vloggerToFollow]["followers"].Add(vloggerName);
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {dict.Count} vloggers in its logs.");

            int number = 1;

            foreach (var vlogger in dict.OrderByDescending(v => v.Value["followers"].Count).ThenBy(v => v.Value["following"].Count))
            {
                Console.WriteLine($"{number}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");

                if (number == 1)
                {
                    foreach (string follower in vlogger.Value["followers"].OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                number++;
            }
        }
    }
}
