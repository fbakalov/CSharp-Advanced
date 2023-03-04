
namespace Telephony;

public class StartUp
{
    static void Main(string[] args)
    {
        List<string> phoneNumbers = Console.ReadLine().Split().ToList();
        List<string> urls = Console.ReadLine().Split().ToList();

        ICallable callable;
        foreach (var phoneNumber in phoneNumbers)
        {
            if (phoneNumber.Length == 10)
            {
                callable = new Smartphone();
            }
            else
            {
                callable = new StationaryPhone();
            }

            try
            {
                Console.WriteLine(callable.Call(phoneNumber));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        IBrowseble browseble = new Smartphone();
        foreach (var url in urls)
        {
            try
            {
                Console.WriteLine(browseble.Browse(url));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}