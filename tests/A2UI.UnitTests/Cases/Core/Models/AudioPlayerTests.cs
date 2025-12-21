namespace A2UI.UnitTests.Cases.Core.Models;

public class AudioPlayerTests
{

    [Fact]
    public void Serialize_And_Deserialize_AudioPlayer_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateAudioPlayer();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.AudioPlayer);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.AudioPlayer);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

}
