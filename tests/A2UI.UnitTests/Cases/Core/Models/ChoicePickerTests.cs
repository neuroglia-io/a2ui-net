namespace A2UI.UnitTests.Cases.Core.Models;

public class ChoicePickerTests
{

    [Fact]
    public void Serialize_And_Deserialize_ChoicePicker_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateChoicePicker();
        
        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.ChoicePicker);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.ChoicePicker);
        
        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

}