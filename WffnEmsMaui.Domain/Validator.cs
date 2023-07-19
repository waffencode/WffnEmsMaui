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

    [GeneratedRegex("^([A-Z][a-z]+([-][A-Z])?[a-z]+)$")]
    private static partial Regex Name();
}