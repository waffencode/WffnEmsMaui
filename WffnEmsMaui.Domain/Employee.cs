using System.Net.Mail;

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

    private string _phone;
    public string Phone
    {
        get => _phone;
        set => _phone = (Validator.IsValidPhoneNumber(value)) ? value : throw new FormatException("Invalid phone number.");
    }

    public Address Address { get; set; }
}