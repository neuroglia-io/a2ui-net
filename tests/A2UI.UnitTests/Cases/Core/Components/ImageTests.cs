namespace A2UI.UnitTests.Cases.Core.Components;

public class ImageTests
{

    [Fact]
    public void Serialize_And_Deserialize_Image_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateImage();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Image);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Image);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

}
