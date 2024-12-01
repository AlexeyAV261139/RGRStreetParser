using RGRStreetParser;

namespace Tests;

public class UnitTest1
{
    [Theory]
    [InlineData("������ �.�. � ������ � 10 � 5 � 89001234567")]
    [InlineData("������ �.�. � �������� � 15 � 12 � 89007654321")]
    [InlineData("������� �.�. � ��������� � 23 � 8 � 89009876543")]
    [InlineData("����������� �.�. � ����������� � 5 � 2 � 89001112233")]
    [InlineData("�������� �.�. � ��������� � 18 � 25 � 89005554433")]

    public void StringToSubscribersTest(string line)
    {
        var data = new SubscribersData(line);

    }
}