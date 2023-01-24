using System;
using System.Linq;
using System.Text;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> filter = x => x[0] == char.ToUpper(x[0]) && char.IsLetter(x[0]);

            string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => filter(x)).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, text));

        }
    }
}
