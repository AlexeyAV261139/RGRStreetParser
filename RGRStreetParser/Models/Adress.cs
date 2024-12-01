namespace RGRStreetParser.Models;

public class Adress
{
    public Adress(string street, string houseNumber, string apartmentNumber)
    {
        Street = street;
        HouseNumber = houseNumber;
        ApartmentNumber = apartmentNumber;
    }

    public string Street { get; set; }

    public string HouseNumber { get; set; }

    public string ApartmentNumber { get; set; }
}

