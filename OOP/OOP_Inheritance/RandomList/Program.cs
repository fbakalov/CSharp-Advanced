namespace CustomRandomList;

public class StartUp
{
    static void Main(string[] args)
    {
       RandomList r = new RandomList();
        r.Add("dasd");
        r.Add("q");
        r.Add("w");
        r.Add("e");
        r.Add("rrr");
        r.Add("t");
        r.Add("y");
        r.Add("u");
        r.Add("i");
        r.Add("o");
        Console.WriteLine(string.Join(" ", r));
        r.RemoveRandomElement();
        r.RemoveRandomElement();
        Console.WriteLine(string.Join(" ", r));
    }
}