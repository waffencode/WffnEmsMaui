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
            if (Regex.IsMatch(value, "^[A-Z]+[\\s|-]?[a-zA-Z]+[\\s|-]?[a-zA-Z]+$"))
            {
                _name = value;
            }
            else
            {
                throw new ArgumentException("Invalid name.");
            }
        }
    }

    public string Surname { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
}