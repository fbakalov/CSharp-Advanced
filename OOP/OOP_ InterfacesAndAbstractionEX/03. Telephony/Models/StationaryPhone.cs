
namespace Telephony;

public class StationaryPhone : ICallable
{
    public string Call(string number)
    {
        if (!ValidateNumber(number))
        {
            throw new ArgumentException("Invalid number!");
        }

        return $"Dialing... {number}";
    }

    private bool ValidateNumber(string phoneNumber)
       => phoneNumber.All(c => Char.IsDigit(c));
}

