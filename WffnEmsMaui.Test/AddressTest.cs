using Netizine.Enums;
using WffnEmsMaui.Domain;

namespace WffnEmsMaui.Test;

public class AddressTest
{
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
    }
}