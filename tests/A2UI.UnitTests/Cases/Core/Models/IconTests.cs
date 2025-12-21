namespace A2UI.UnitTests.Cases.Core.Models;

public class IconTests
{

    [Fact]
    public void Serialize_And_Deserialize_Icon_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateIcon();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Icon);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Icon);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

}
