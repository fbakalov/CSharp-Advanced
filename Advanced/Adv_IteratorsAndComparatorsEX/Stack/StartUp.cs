using System;

namespace Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            CustomStack<string> customStack = new();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split();

                string action = tokens[0];

                if (action == "Push")
                {
                    foreach (string element in tokens.Skip(1)) 
                    {
                        customStack.Push(element.TrimEnd(','));
                    }
                }
                else if (action == "Pop")
                {
                    try
                    {
                        customStack.Pop();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            foreach (var item in customStack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in customStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
