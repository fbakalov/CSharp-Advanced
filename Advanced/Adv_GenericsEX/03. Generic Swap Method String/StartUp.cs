
namespace GenericBoxOfString;

class StartUp
{
    public static void Main(string[] args)
    {
        Box<string> box = new Box<string>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            box.Add(Console.ReadLine());
        }

        int[] indexes = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        box.Swap(indexes[0], indexes[1]);
        Console.WriteLine(box.ToString());
    }

}