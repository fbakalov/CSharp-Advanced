using System;

namespace Date_Modifier
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();

            int diffrenceInDays = DateModifier.GetDifferenceInDays(start, end);
            Console.WriteLine(diffrenceInDays);
        }
    }
}
