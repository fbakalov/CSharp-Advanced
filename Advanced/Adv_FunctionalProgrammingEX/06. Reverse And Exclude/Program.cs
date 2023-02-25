using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int nToDivide = int.Parse(Console.ReadLine());

            numbers = numbers.Where(x => x % nToDivide != 0).Reverse().ToArray();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
