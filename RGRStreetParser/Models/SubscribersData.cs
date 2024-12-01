using System.ComponentModel.DataAnnotations;

namespace RGRStreetParser.Models;

public class SubscribersData()
{
    public required Initials Initials { get; set; }

    public required Adress Adress { get; set; }
    public required string PhoneNumber { get; set; }
}

