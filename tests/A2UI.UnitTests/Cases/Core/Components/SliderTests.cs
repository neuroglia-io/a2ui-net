namespace A2UI.UnitTests.Cases.Core.Components;

public class SliderTests
{

    [Fact]
    public void Serialize_And_Deserialize_Slider_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateSlider();
        
        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Slider);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Slider);
        
        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

}