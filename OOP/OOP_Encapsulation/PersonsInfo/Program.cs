namespace PersonInfo;

public class StartUp
{
    public static void Main(string[] args)
    {
        var lines = int.Parse(Console.ReadLine());

        var persons = new List<Person>();

        for (int i = 0; i < lines; i++)
        {
            var cmdArgs = Console.ReadLine().Split();
            var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
            persons.Add(person);
        }

        var sorted = persons.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList();
        Console.WriteLine(string.Join(Environment.NewLine, sorted));
    }
}