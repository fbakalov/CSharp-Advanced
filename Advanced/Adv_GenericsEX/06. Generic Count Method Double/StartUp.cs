namespace GenericBoxOfDouble;

class StartUp
{
    public static void Main(string[] args)
    {
        Box<double> box = new Box<double>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            box.Add(double.Parse(Console.ReadLine()));
        }

        double comparer = double.Parse(Console.ReadLine());

        Console.WriteLine(box.CountOfBigger(comparer));
    }
    
}