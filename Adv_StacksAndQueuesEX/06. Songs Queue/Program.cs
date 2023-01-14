using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new(
                Console.ReadLine()
                 .Split(", ")
            );

            while (songs.Any())
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split();
                string command = cmdArgs[0];

                switch (command)
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        string song = string.Join(" ", cmdArgs.Skip(1));
                        if (!songs.Contains(song))
                        {
                            songs.Enqueue(song);
                        }
                        else
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;
                }

            }
            Console.WriteLine("No more songs!");
        }
    }
}
