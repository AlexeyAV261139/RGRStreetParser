using RGRStreetParser;

namespace Tests;

public class UnitTest1
{
    [Theory]
    [InlineData("»ванов ».». Ц Ћенина Ц 10 Ц 5 Ц 89001234567")]
    [InlineData("ѕетров ѕ.ѕ. Ц √агарина Ц 15 Ц 12 Ц 89007654321")]
    [InlineData("—идоров —.—. Ц  ировска€ Ц 23 Ц 8 Ц 89009876543")]
    [InlineData("јлександров ј.ј. Ц ÷ентральна€ Ц 5 Ц 2 Ц 89001112233")]
    [InlineData(" узнецов  . . Ц —оветска€ Ц 18 Ц 25 Ц 89005554433")]

    public void StringToSubscribersTest(string line)
    {
        var data = new SubscribersData(line);

    }
}