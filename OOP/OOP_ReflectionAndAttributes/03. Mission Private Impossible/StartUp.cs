﻿using System.Reflection;

namespace Stealer;

public class StartUp
{
    static void Main(string[] args)
    {
        Spy spy = new Spy();
        string result = spy.RevealPrivateMethods("Hacker");
        Console.WriteLine(result);
    }
}