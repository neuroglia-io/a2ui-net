namespace A2UI.UnitTests.Cases.Core.Models;

public class ColumnTests
{

    [Fact]
    public void Serialize_And_Deserialize_Column_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateColumn();
        
        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Column);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Column);
       
        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

}