using FluentValidation;
using RGRStreetParser.Interfaces;
using RGRStreetParser.Models;
using RGRStreetParser.Validators;

namespace RGRStreetParser;

public class SubscribersDataTxtFileStorage : ISubscribersDataStorageGetter
{
    private readonly SubscribersDataValidator _validator;
    public string FilePath { get;}

    public SubscribersDataTxtFileStorage(string filePath)
    {
        FilePath = filePath;
        _validator = new();
    }

    public IEnumerable<SubscribersData> GetSubscribersData()
    {
        string[] lines = GetFileLines(FilePath);

        IEnumerable<SubscribersData> subscribesData = lines
            .Select(GetSubscribersDataFromLine)
            .Where(x => x != null)!;

        return subscribesData;
    }
    private string[] GetFileLines(string filePath)
    {
        if (!File.Exists(filePath))
            return [];
        var lines = File.ReadAllLines(filePath);
        return lines;
    }

    private SubscribersData? GetSubscribersDataFromLine(string line)
    {
        var data = line
            .Trim()
            .Split(" – ");

        if (data.Length != 5)
            return null;
        
        string[] initialSubstrings = data[0].Split(" ");     

        SubscribersData subscribersData = new()
        {
            Initials = new Initials(
                surname: initialSubstrings[0],
                name: initialSubstrings[1].Substring(0, 1),
                patronymic: initialSubstrings[1].Substring(2, 1)),
            Adress = new Adress(
                street: data[1],
                houseNumber: data[2],
                apartmentNumber: data[3]),
            PhoneNumber = data[4]
        };

        _validator.ValidateAndThrow(subscribersData);

        return subscribersData;
    }
}