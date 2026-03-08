namespace A2UI.UnitTests.Cases.Core.Components;

public class DateTimeInputTests
{

    [Fact]
    public void Serialize_And_Deserialize_DateTimeInput_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateDateTimeInput();
        
        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.DateTimeInput);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.DateTimeInput);
        
        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

}