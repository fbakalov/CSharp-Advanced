
namespace DefiningClasses
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                family.AddMember(new Person(input[0], int.Parse(input[1])));
            }

            List<Person> peopleOver30 = family.GetPeopleOlderThan30();
            foreach (Person person in peopleOver30)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}




