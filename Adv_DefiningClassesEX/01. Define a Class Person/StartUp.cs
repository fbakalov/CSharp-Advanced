using System;

namespace DefiningClasses
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            Person person = new();
            person.Name = "ivan";
            person.Age = 32;
            Console.WriteLine(person.Name + " " + person.Age);
        }
    }
    
}
