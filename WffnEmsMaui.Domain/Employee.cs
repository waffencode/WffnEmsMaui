using System.Net.Mail;
using System.Text.RegularExpressions;

namespace WffnEmsMaui.Domain;

public class Employee
{
    public Guid Id { get; } = Guid.NewGuid();

    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            // Regex for name which starts with a capital, e.g. "Test".
            if (Regex.IsMatch(value, "^[A-Z]+[\\s|-]?[a-z]+[\\s|-]?[a-z]+$"))
            {
                _name = value;
            }
            else
            {
                throw new FormatException("Invalid name.");
            }
        }
    }

    private string _surname;
    public string Surname
    {
        get => _surname;
        set
        {
            // Regex for surname which starts with a capital, e.g. "Test".
            if (Regex.IsMatch(value, "^[A-Z]+[\\s|-]?[a-z]+[\\s|-]?[a-z]+$"))
            {
                _surname = value;
            }
            else
            {
                throw new FormatException("Invalid surname.");
            }
        }
    }

    public MailAddress Email { get; set; }
    public string Phone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
}