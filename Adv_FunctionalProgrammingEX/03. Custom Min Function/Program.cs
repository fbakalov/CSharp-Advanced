using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> min = nums =>
            {
                int smallest = 0;
                bool firstTime = true;
                for (int i = 0; i < nums.Length; i++)
                {
                    int currNum = nums[i];
                    if (firstTime)
                    {
                        smallest = currNum;
                        firstTime = false;
                        continue;
                    }

                    if (currNum < smallest)
                    {
                        smallest = currNum;
                    }
                }
                return smallest;
            };

            Console.WriteLine(min(numbers));
        }
    }
}
