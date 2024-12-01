using RGRStreetParser.Models;

namespace RGRStreetParser.Interfaces;

public interface ISubscribersDataStorage
{
    public IEnumerable<SubscribersData> GetSubscribersData();
}

