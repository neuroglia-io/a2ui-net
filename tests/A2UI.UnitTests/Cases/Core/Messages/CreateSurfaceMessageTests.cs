namespace A2UI.UnitTests.Cases.Core.Messages;

public class CreateSurfaceMessageTests
{

    [Fact]
    public void Serialize_And_Deserialize_CreateSurfaceMessage_Should_Work()
    {
        //arrange
        var toSerialize = MessageFactory.CreateSurfaceMessage();
        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.CreateSurfaceMessage);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.CreateSurfaceMessage);
        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

}
