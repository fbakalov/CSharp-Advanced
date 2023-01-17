using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] arguments = input.Split(", ");

                string move = arguments[0];
                string plate = arguments[1];

                if (move == "IN")
                {
                    set.Add(plate);
                }
                else
                {
                    set.Remove(plate);
                }
            }

            foreach (var plate in set)
            {
                Console.WriteLine(plate);
            }
        }
    }
}
