using Netizine.Enums;
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

    [Fact]
    public void ShouldReturnValidPhoneNumber()
    {
        const string number = "+79008001010";
        Employee employee = new()
        {
            Phone = number
        };

        Assert.Equal(number, employee.Phone);
    }

    [Fact]
    public void ShouldAcceptValidPhoneNumber()
    {
        Employee employee = new();
        var exception = Record.Exception(() => ChangeEmployeePhoneNumber(employee, "+79008001010"));
        Assert.Null(exception);
    }

    [Fact]
    public void ShouldThrowExceptionOnInvalidPhoneNumber()
    {
        Employee employee = new();
        var testNumbers = new string[4] { "+79008001f1", "79008001010", "+7900800101", "+79008001010798" };

        foreach (var number in testNumbers)
        {
            var exception = Record.Exception(() => ChangeEmployeePhoneNumber(employee, number));
            Assert.NotNull(exception);
        }
    }

    [Fact]
    public void ShouldAcceptValidAddress()
    {
        Address address = new()
        {
            Country = Country.UnitedStatesOfAmerica,
            State = "California",
            City = "Los Angeles",
            PostalCode = "000000",
            Street = "Example st.",
            House = "0",
            Apartment = "0"
        };
        Employee employee = new();
        employee.Address = address;
        Assert.Equal(address, employee.Address);
    }

    private static void ChangeEmployeeName(Employee employee, string name)
    {
        employee.Name = name;
    }

    private static void ChangeEmployeeSurname(Employee employee, string surname)
    {
        employee.Surname = surname;
    }

    private static void ChangeEmployeePhoneNumber(Employee employee, string number)
    {
        employee.Phone = number;
    }
}