using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new();
            Dictionary<string, Dictionary<string, int>> users = new();

            string contestInput;
            while ((contestInput = Console.ReadLine()) != "end of contests")
            {
                string[] tokens = contestInput.Split(":");
                string contestName = tokens[0];
                string contestPassWord = tokens[1];
                contests.Add(contestName, contestPassWord);
            }

            string submission;
            while ((submission = Console.ReadLine()) != "end of submissions")
            {
                string[] tokens = submission.Split("=>");

                string contest = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (users.ContainsKey(username) && users[username].ContainsKey(contest))
                    {
                        if (users[username][contest] < points)
                        {
                            users[username][contest] = points;
                        }
                    }
                    else
                    {
                        if (!users.ContainsKey(username))
                        {
                            users.Add(username, new Dictionary<string, int>());
                        }       
                        users[username].Add(contest, points);
                    }
                }
            }

            int biggestWholeScore = 0;
            string bestCandidate = string.Empty;

            foreach (var user in users)
            {
                int currWholeScore = 0;
                foreach (var contest in user.Value)
                {
                    currWholeScore += contest.Value;
                }
                if (currWholeScore > biggestWholeScore)
                {
                    biggestWholeScore = currWholeScore;
                    bestCandidate = user.Key;
                }
            }

            users = users.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"Best candidate is {bestCandidate} with total {biggestWholeScore} points.");
            Console.WriteLine("Ranking:");
            foreach (var user in users)
            {
                Dictionary<string, int> dict = user.Value;
                dict = user.Value.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine(user.Key);
                foreach (var contestSub in dict)
                {
                    Console.WriteLine($"#  {contestSub.Key} -> {contestSub.Value}");
                }
            }
        }
    }
}
