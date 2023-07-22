using System.Net.Mail;
using System.Text.RegularExpressions;

namespace WffnEmsMaui.Domain;

public static partial class Validator
{
    public static bool IsValidName(string name)
    {
        return Name().IsMatch(name);

    }

    public static bool IsValidEmail(string email)
    {
        try
        {
            MailAddress mail = new(email);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public static bool IsValidPhoneNumber(string number)
    {
        return PhoneNumber().IsMatch(number);
    }

    [GeneratedRegex("^([A-Z][a-z]+([-][A-Z])?[a-z]+)$")]
    private static partial Regex Name();

    [GeneratedRegex("^(\\+[0-9]{11,13})$")]
    private static partial Regex PhoneNumber();
}