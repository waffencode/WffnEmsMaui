using Netizine.Enums;
using WffnEmsMaui.Domain;

namespace WffnEmsMaui.Test;

public class AddressTest
{
    [Fact]
    public void ShouldAcceptValidCountry()
    {
        Address address = new();
        address.Country = Country.UnitedStatesOfAmerica;
        Assert.Equal(Country.UnitedStatesOfAmerica, address.Country);
    }

    [Fact]
    public void ShouldAcceptValidState()
    {
        Address address = new();
        address.State = "California";
        Assert.Equal("California", address.State);
    }

    [Fact]
    public void ShouldAcceptValidCity()
    {
        Address address = new();
        address.City = "Los Angeles";
        Assert.Equal("Los Angeles", address.City);
    }

    [Fact]
    public void ShouldAcceptValidPostalCode()
    {
        Address address = new();
        address.PostalCode = "000000";
        Assert.Equal("000000", address.PostalCode);
    }

    [Fact]
    public void ShouldAcceptValidStreet()
    {
        Address address = new();
        address.Street = "Example st.";
        Assert.Equal("Example st.", address.Street);
    }

    [Fact]
    public void ShouldAcceptValidHouse()
    {
        Address address = new();
        address.House = "0";
        Assert.Equal("0", address.House);
    }

    [Fact]
    public void ShouldAcceptValidApartment()
    {
        Address address = new();
        address.Apartment = "0";
        Assert.Equal("0", address.Apartment);
    }

    [Fact]
    public void ShouldReturnValidStringRepresentation()
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
        var result = address.ToString();
        Assert.Equal("0 0 Example st., 000000 Los Angeles, California, United States of America", result);
    }
}