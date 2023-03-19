

using AuthorProblem;
using Stealer;
using System.Reflection;

namespace _06._Code_Tracker
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            var type = typeof(StartUp);

            foreach (var method in type.GetMethods((BindingFlags)60))
            {
                AuthorAttribute[] attrs = method.GetCustomAttributes<AuthorAttribute>().ToArray();

                foreach (var attr in attrs)
                {
                    Console.WriteLine($"{method.Name} is written by {attr.Name}");
                }
            }
        }
    }
}
