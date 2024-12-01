namespace RGRStreetParser.Models;

public class Initials
{
    public Initials(string surname, string name, string patronymic)
    {
        Surname = surname;
        Name = name;
        Patronymic = patronymic;
    }

    public string Surname { get; set; }

    public string Name { get; set; }

    public string Patronymic { get; set; }
}

