namespace A2UI.UnitTests.Cases.Core.Models;

public class ButtonTests
{

    [Fact]
    public void Serialize_And_Deserialize_Button_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateButton();
        
        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Button);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Button);
       
        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

}