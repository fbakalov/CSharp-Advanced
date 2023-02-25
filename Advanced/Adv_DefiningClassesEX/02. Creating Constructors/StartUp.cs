using System;

namespace DefiningClasses
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            Person person1 = new Person();
            Console.WriteLine($"{person1.Name} {person1.Age}");
            Person person2 = new Person(int.Parse(Console.ReadLine()));
            Console.WriteLine($"{person2.Name} {person2.Age}");
            Person person3 = new Person(Console.ReadLine(), int.Parse(Console.ReadLine()));
            Console.WriteLine($"{person3.Name} {person3.Age}");
        }
    }
    
}
