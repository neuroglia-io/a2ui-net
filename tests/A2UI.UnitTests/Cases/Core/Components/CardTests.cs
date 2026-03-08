namespace A2UI.UnitTests.Cases.Core.Components;

public class CardTests
{

    [Fact]
    public void Serialize_And_Deserialize_Card_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateCard();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Card);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Card);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

}