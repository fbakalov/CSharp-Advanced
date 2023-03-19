using System.Reflection;

namespace Stealer;

public class StartUp
{
    static void Main(string[] args)
    {
        Hacker hacker = new Hacker();

        Type typeHacker = hacker.GetType();

        Spy spy = new Spy();
        Console.WriteLine(spy.StealFieldInfo(typeHacker.Name, new string[] { "username", "password" })); 
    }
}