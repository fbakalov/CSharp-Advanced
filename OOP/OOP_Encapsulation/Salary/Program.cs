namespace PersonInfo;

public class StartUp
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Person> people = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] cmdArgs = Console.ReadLine().Split();

            Person person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));

            people.Add(person);
        }

        var parcentage = decimal.Parse(Console.ReadLine());

        people.ForEach(p => p.IncreaseSalary(parcentage));

        people.ForEach(p => Console.WriteLine(p.ToString()));
    }
}