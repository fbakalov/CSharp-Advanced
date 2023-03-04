

using System;

namespace Telephony;

public class Smartphone : ICallable, IBrowseble
{
    public string Browse(string url)
    {
        if (!ValidateUrl(url))
        {
            throw new ArgumentException("Invalid URL!");
        }
        return $"Browsing: {url}!";
    }

    public string Call(string number)
    {
        if (!ValidateNumber(number))
        {
            throw new ArgumentException("Invalid number!");
        }
        return $"Calling... {number}";
    }

    private bool ValidateNumber(string phoneNumber)
       => phoneNumber.All(c => Char.IsDigit(c));

    private bool ValidateUrl(string url)
        => url.All(c => !Char.IsDigit(c));
}
