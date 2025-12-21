namespace A2UI.UnitTests.Cases.Core.Models;

public class TextTests
{

    [Fact]
    public void Serialize_And_Deserialize_Text_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateText();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Text);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Text);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

}
