namespace A2UI.UnitTests.Cases.Core.Messages;

public class DeleteSurfaceMessageTests
{
    [Fact]
    public void Serialize_And_Deserialize_DeleteSurfaceMessage_Should_Work()
    {
        //arrange
        var toSerialize = MessageFactory.CreateDeleteSurfaceMessage();
        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.DeleteSurfaceMessage);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.DeleteSurfaceMessage);
        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }
}