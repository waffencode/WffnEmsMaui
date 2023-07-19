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
        set => _name = (Validator.IsValidName(value)) ? value : throw new FormatException("Invalid name.");
    }

    private string _surname;
    public string Surname
    {
        get => _surname;
        set => _surname = (Validator.IsValidName(value)) ? value : throw new FormatException("Invalid surname.");
    }

    public MailAddress Email { get; set; }
    public string Phone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
}