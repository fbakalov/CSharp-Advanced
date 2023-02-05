namespace GenericScale;

class StartUp
{
    public static void Main(string[] args)
    {
        EqualityScale<int> equalityScale = new(3, 3);
        Console.WriteLine(equalityScale.AreEqual());
    }
}