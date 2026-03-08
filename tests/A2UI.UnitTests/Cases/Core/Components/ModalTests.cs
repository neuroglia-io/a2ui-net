namespace A2UI.UnitTests.Cases.Core.Components;

public class ModalTests
{

    [Fact]
    public void Serialize_And_Deserialize_Modal_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateModal();
        
        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Modal);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Modal);
        
        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

}