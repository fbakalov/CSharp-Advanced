using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentsAndGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] enter = Console.ReadLine().Split();
                string name = enter[0];
                decimal grade = decimal.Parse(enter[1]);

                if (!studentsAndGrades.ContainsKey(name))
                {
                    studentsAndGrades.Add(name, new List<decimal>());
                }

                studentsAndGrades[name].Add(grade);
            }

            foreach (var line in studentsAndGrades)
            {
                Console.Write($"{line.Key} -> ");
                foreach (var item in line.Value)
                {
                    Console.Write($"{item:f2} ");
                }
                Console.Write($"(avg: { line.Value.Average():f2})");
                Console.WriteLine();
            }
        }
    }
}
