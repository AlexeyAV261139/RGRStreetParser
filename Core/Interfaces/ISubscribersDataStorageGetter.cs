using RGRStreetParser.Models;

namespace RGRStreetParser.Interfaces;

public interface ISubscribersDataStorageGetter
{
    public IEnumerable<SubscribersData> GetSubscribersData();
}

