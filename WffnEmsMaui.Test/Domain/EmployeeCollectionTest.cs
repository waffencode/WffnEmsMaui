using Netizine.Enums;
using WffnEmsMaui.Domain;

namespace WffnEmsMaui.Test.Domain;

public class EmployeeCollectionTest
{
    [Fact]
    public void ShouldAddValidItems()
    {
        EmployeeCollection collection = new();
        Employee employee = new()
        {
            Name = "Test",
            Surname = "Test",
            Address = new()
            {
                Country = Country.UnitedStatesOfAmerica,
                State = "California",
                City = "Los Angeles",
                PostalCode = "000000",
                Street = "Example st.",
                House = "0",
                Apartment = "0"
            },
            Phone = "+78008008080",
            Email = new("example@example.com")
        };
        collection.Add(employee);
        Assert.Contains<Employee>(employee, collection.List);
    }

    [Fact]
    public void ShouldReturnValidItems()
    {
        EmployeeCollection collection = new();
        Employee employee = new()
        {
            Name = "Test",
            Surname = "Test",
            Address = new()
            {
                Country = Country.UnitedStatesOfAmerica,
                State = "California",
                City = "Los Angeles",
                PostalCode = "000000",
                Street = "Example st.",
                House = "0",
                Apartment = "0"
            },
            Phone = "+78008008080",
            Email = new("example@example.com")
        };
        collection.Add(employee);
        Assert.Equal(employee, collection.Get(0));
    }
}