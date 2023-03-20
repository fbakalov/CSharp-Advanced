namespace ValidationAttributes
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person person = new("Stefan", 18);

            Console.WriteLine(Validator.IsValid(person));
        }
    }
}
