using System.Net.Mail;
using WffnEmsMaui.Domain;

namespace WffnEmsMaui.Test;

public class EmployeeTest
{
    [Fact]
    public void IdShouldNotBeNull()
    {
        Employee employee = new();
        Assert.NotEqual(Guid.Empty, employee.Id);
    }

    [Fact]
    public void ShouldAcceptValidName()
    {
        Employee employee = new();
        var exception = Record.Exception(() => ChangeEmployeeName(employee, "Test"));
        Assert.Null(exception);
    }

    [Fact]
    public void ShouldThrowExceptionForInvalidName()
    {
        Employee employee = new();

        Exception? exception = Record.Exception(() => ChangeEmployeeName(employee, "test"));
        Assert.NotNull(exception);
        exception = Record.Exception(() => ChangeEmployeeName(employee, "tEsT"));
        Assert.NotNull(exception);
        exception = Record.Exception(() => ChangeEmployeeName(employee, "TesT"));
        Assert.NotNull(exception);
    }

    [Fact]
    public void ShouldAcceptValidSurname()
    {
        Employee employee = new();
        var exception = Record.Exception(() => ChangeEmployeeSurname(employee, "Test"));
        Assert.Null(exception);
    }

    [Fact]
    public void ShouldThrowExceptionForInvalidSurname()
    {
        Employee employee = new();

        Exception? exception = Record.Exception(() => ChangeEmployeeSurname(employee, "test"));
        Assert.NotNull(exception);
        exception = Record.Exception(() => ChangeEmployeeSurname(employee, "tEsT"));
        Assert.NotNull(exception);
        exception = Record.Exception(() => ChangeEmployeeSurname(employee, "TesT"));
        Assert.NotNull(exception);
    }

    [Fact]
    public void ShouldReturnValidName()
    {
        Employee employee = new()
        {
            Name = "Test"
        };
        Assert.Equal("Test", employee.Name);
    }

    [Fact]
    public void ShouldReturnValidSurname()
    {
        Employee employee = new()
        {
            Surname = "Test"
        };
        Assert.Equal("Test", employee.Surname);
    }

    [Fact]
    public void ShouldReturnValidEmail()
    {
        
        MailAddress mail = new("example@example.com");
        Employee employee = new()
        {
            Email = mail
        };
        Assert.Equal(mail, employee.Email);
    }

    private static void ChangeEmployeeName(Employee employee, string name)
    {
        employee.Name = name;
    }

    private static void ChangeEmployeeSurname(Employee employee, string surname)
    {
        employee.Surname = surname;
    }
}