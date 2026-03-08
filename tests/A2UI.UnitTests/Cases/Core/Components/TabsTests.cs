namespace A2UI.UnitTests.Cases.Core.Components;

public class TabsTests
{

    [Fact]
    public void Serialize_And_Deserialize_Tabs_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateTabs();
        
        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Tabs);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Tabs);
        
        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeEquivalentTo(toSerialize);
    }

}