namespace A2UI.UnitTests.Cases.Core.Models;

public class VideoTests
{

    [Fact]
    public void Serialize_And_Deserialize_Video_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateVideo();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Video);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Video);
        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

}