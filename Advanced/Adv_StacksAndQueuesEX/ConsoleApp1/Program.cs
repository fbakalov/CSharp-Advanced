using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(" ");

            arr = arr.Reverse().ToArray();
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
