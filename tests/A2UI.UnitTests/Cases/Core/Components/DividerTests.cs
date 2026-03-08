namespace A2UI.UnitTests.Cases.Core.Components;

public class DividerTests
{

    [Fact]
    public void Serialize_And_Deserialize_Divider_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateDivider();
        
        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Divider);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Divider);
        
        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

}