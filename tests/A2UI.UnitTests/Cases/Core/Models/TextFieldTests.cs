namespace A2UI.UnitTests.Cases.Core.Models;

public class TextFieldTests
{

    [Fact]
    public void Serialize_And_Deserialize_TextField_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateTextField();
        
        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.TextField);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.TextField);
        
        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

}