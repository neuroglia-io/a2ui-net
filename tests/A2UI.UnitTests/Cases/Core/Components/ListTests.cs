namespace A2UI.UnitTests.Cases.Core.Components;

public class ListTests
{

    [Fact]
    public void Serialize_And_Deserialize_List_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateList();
        
        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.List);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.List);
        
        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeJsonEquivalentTo(toSerialize);
    }

}