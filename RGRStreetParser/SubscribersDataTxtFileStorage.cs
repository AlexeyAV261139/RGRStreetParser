using FluentValidation;
using RGRStreetParser.Interfaces;
using RGRStreetParser.Models;
using RGRStreetParser.Validators;

namespace RGRStreetParser;

public class SubscribersDataTxtFileStorage : ISubscribersDataStorage
{
    private readonly SubscribersDataValidator _validator;
    public string FilePath { get;}

    public SubscribersDataTxtFileStorage(string filePath)
    {
        FilePath = filePath;
        _validator = new();
    }

    public  IEnumerable<SubscribersData> GetSubscribersData()
    {
        IEnumerable<string> lines = GetFileLines(FilePath);

        IEnumerable<SubscribersData> subscribesData = lines
            .Select(GetSubscribersDataFromLine)
            .Where(x => x != null)!;

        return subscribesData;
    }
    private IEnumerable<string> GetFileLines(string filePath)
    {
        if (!File.Exists(filePath))
            return [];
        return File.ReadAllLines(filePath);
    }

    private SubscribersData? GetSubscribersDataFromLine(string line)
    {
        var data = line.Split(" – ");

        if (data.Length != 6)
            return null;
        
        string[] initialSubstrings = data[0].Split(" ");     

        SubscribersData subscribersData = new()
        {
            Initials = new Initials(
                surname: initialSubstrings[0],
                name: initialSubstrings[1].Substring(0, 2),
                patronymic: initialSubstrings[1].Substring(2, 2)),
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