﻿namespace GenericBoxOfString;

class StartUp
{
    public static void Main(string[] args)
    {
        Box<string> box = new Box<string>();
        
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            box.Add(Console.ReadLine());
        }

        Console.WriteLine(box.ToString());
    }
}