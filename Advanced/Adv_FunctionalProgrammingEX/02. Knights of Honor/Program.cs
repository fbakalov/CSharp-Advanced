using System;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Action<string[]> printOnNewLine = x => 
            {
                foreach (var word in x)
                {
                    Console.WriteLine("Sir " + word);
                }
            };
            printOnNewLine(input);
        }
    }
}
