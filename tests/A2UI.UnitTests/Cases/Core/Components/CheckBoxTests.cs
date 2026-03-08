namespace A2UI.UnitTests.Cases.Core.Components;

public class CheckBoxTests
{

    [Fact]
    public void Serialize_And_Deserialize_CheckBox_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateCheckBox();
        
        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.CheckBox);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.CheckBox);
        
        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

}