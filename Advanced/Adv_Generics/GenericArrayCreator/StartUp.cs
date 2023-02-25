namespace GenericArrayCreator;

class StartUp
{
    public static void Main(string[] args)
    {
        int[] arr = ArrayCreator.Create(5, 2);
        Console.WriteLine(string.Join(" ", arr));
    }
}