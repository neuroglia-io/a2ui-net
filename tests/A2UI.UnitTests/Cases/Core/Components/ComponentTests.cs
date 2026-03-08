namespace A2UI.UnitTests.Cases.Core.Components;

public class ComponentTests
{

    [Fact]
    public void Serialize_And_Deserialize_AudioPlayer_Component_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateAudioPlayer();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Component);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Component);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeJsonEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_Button_Component_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateButton();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Component);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Component);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeJsonEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_Card_Component_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateCard();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Component);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Component);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeJsonEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_CheckBox_Component_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateCheckBox();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Component);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Component);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeJsonEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_ChoicePicker_Component_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateChoicePicker();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Component);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Component);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeJsonEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_Column_Component_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateColumn();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Component);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Component);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeJsonEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_DateTimeInput_Component_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateDateTimeInput();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Component);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Component);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeJsonEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_Divider_Component_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateDivider();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Component);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Component);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeJsonEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_Icon_Component_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateIcon();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Component);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Component);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeJsonEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_Image_Component_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateImage();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Component);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Component);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeJsonEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_List_Component_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateList();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Component);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Component);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeJsonEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_Modal_Component_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateModal();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Component);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Component);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeJsonEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_Row_Component_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateRow();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Component);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Component);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeJsonEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_Slider_Component_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateSlider();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Component);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Component);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeJsonEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_Tabs_Component_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateTabs();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Component);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Component);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeJsonEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_Text_Component_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateText();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Component);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Component);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeJsonEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_TextField_Component_Should_Work()
    {
        //arrange
        var toSerialize = ComponentFactory.CreateTextField();
        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Component);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Component);
        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeJsonEquivalentTo(toSerialize);
    }

    [Fact]
    public void Serialize_And_Deserialize_Video_Component_Should_Work()
    {

        //arrange
        var toSerialize = ComponentFactory.CreateVideo();

        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.Component);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.Component);

        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeJsonEquivalentTo(toSerialize);
    }

}