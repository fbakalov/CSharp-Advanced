using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> stack = new();
            string text = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string[] cmаArgs = Console.ReadLine().Split();
                int querry = int.Parse(cmаArgs[0]);

                if (querry == 1)
                {
                    stack.Push(text);
                    text += cmаArgs[1];                
                }
                if (querry == 2)
                {
                    stack.Push(text);
                    int startIndex = text.Length - (int.Parse(cmаArgs[1]));
                    text = text.Remove(startIndex);
                }
                if (querry == 3)
                {
                    int index = (int.Parse(cmаArgs[1])) - 1;
                    Console.WriteLine(text[index]);
                }
                if (querry == 4)
                {
                    text = stack.Pop();
                }
            }                           
        }
    }
}
