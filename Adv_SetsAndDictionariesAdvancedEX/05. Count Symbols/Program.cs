using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> countOfChars = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char currentCh = text[i];

                if (!countOfChars.ContainsKey(currentCh))
                {
                    countOfChars.Add(currentCh, 0);
                }

                countOfChars[currentCh]++;
            }

            countOfChars = countOfChars.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in countOfChars)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
