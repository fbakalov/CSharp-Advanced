using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x += x * 0.2)
                .ToArray();

            foreach (var item in arr)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
