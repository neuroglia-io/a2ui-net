namespace A2UI.UnitTests.Cases.Core.Models;

public class RowTests
{

    [Fact]
    public void Serialize_And_Deserialize_Row_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateRow();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Row);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Row);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

}