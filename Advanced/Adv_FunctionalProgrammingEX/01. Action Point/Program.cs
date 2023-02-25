using System;

namespace _01._Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Action<string[]> printOnNewLine = x => Console.WriteLine(string.Join(Environment.NewLine, x));
            printOnNewLine(input);           
        }
    }
}
