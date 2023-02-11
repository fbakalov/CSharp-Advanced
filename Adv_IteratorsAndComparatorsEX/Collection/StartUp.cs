
using System;

namespace ListyIterator
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToList();

            ListyIterator<string> iterator = new ListyIterator<string>(list);

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "Move")
                {
                    Console.WriteLine(iterator.Move()); 
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(iterator.HasNext());
                }
                else if (command == "Print")
                {
                    iterator.Print();
                }
                else if (command == "PrintAll")
                {
                    foreach (var item in iterator)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
