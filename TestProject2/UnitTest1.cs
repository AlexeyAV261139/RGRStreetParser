using RGRStreetParser;
using RGRStreetParser.Interfaces;

namespace TestProject2;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var path = @"C:\Users\User\Desktop\123.txt";
        SubscribersDataTxtFileStorage storage = new(path);

        var data = storage.GetSubscribersData().ToArray();

        Assert.Equal(5, data.Length);
    }
}