using _06._Code_Tracker;
using AuthorProblem;
using System.Reflection;

namespace Stealer;

[Author("Viktor")]
public class StartUp
{
    [Author("George")]
    static void Main(string[] args)
    {
        var tracker = new Tracker();
        tracker.PrintMethodsByAuthor();
    }
}