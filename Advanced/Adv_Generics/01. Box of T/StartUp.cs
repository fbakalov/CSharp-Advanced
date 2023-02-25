namespace BoxOfT
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            box.Add(1);
            box.Add(2);
            box.Add(3);
            box.Add(4);
            box.Add(5);
            box.Add(6);
            Console.WriteLine(box.Remove());
            Console.WriteLine(box.Count);
        }
    }
}