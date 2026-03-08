namespace A2UI.UnitTests.Cases.Core.Messages;

public class UpdateDataModelMessageTests
{
    [Fact]
    public void Serialize_And_Deserialize_UpdateDataModelMessage_Should_Work()
    {
        //arrange
        var toSerialize = MessageFactory.CreateUpdateDataModelMessage();
        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.UpdateDataModelMessage);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.UpdateDataModelMessage);
        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeJsonEquivalentTo(toSerialize);
    }
}
