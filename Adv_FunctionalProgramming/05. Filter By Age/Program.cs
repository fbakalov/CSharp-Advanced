using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(", ");
                people.Add(new Person { name = inputs[0], age = int.Parse(inputs[1]) });
            }

            string filterType = Console.ReadLine();
            int filterValue = int.Parse(Console.ReadLine());

            Func<Person, int, bool> filter = GetFilter(filterType);

            people = people.Where(p => filter(p, filterValue)).ToList();

            Func<Person, int, bool> GetFilter(string filterType)
            {
                if (filterType == "younger")
                {
                    return (p, value) => p.age < value;
                }
                else
                {
                    return (p, value) => p.age >= value;
                }
            }

            string format = Console.ReadLine();

            Action<Person> formatter = GetFormat(format);

            foreach (var person in people)
            {
                formatter(person);
            }

            Action<Person> GetFormat(string formatType)
            {
                if (formatType == "name age")
                {
                    return p => Console.WriteLine($"{p.name} - {p.age}");
                }
                else if (formatType == "name")
                {
                    return p => Console.WriteLine(p.name);
                }
                else
                {
                    return p => Console.WriteLine(p.age);
                }
            }
        }

        class Person 
        {
            public string name;
            public int age;
        }


    }
}
