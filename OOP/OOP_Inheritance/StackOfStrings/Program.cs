namespace CustomStack;

public class StartUp
{
    static void Main(string[] args)
    {
        StackOfStrings strings = new StackOfStrings();
        strings.AddRange(Console.ReadLine().Split());
        Console.WriteLine(string.Join(" ", strings));
    }
}