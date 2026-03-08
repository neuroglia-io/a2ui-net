namespace A2UI.UnitTests.Cases.Core.Messages;

public class UpdateComponentsMessageTests
{
    [Fact]
    public void Serialize_And_Deserialize_UpdateComponentsMessage_Should_Work()
    {
        //arrange
        var toSerialize = MessageFactory.CreateUpdateComponentsMessage();
        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.UpdateComponentsMessage);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.UpdateComponentsMessage);
        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }
}
