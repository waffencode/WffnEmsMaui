using Netizine.Enums;

namespace WffnEmsMaui.Domain;

public struct Address
{
    public Country Country { get; set; }
    public string State { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public string Street { get; set; }
    public string House { get; set; }
    public string Apartment { get; set; }

    public readonly override string ToString()
    {
        return $"{Apartment} {House} {Street}, {PostalCode} {City}, {State}, {Country.GetName()}";
    }
}