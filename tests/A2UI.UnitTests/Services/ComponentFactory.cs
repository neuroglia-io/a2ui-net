// Copyright © 2025-Present the a2ui-net Authors
//
// Licensed under the Apache License, Version 2.0 (the "License"),
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using A2UI.Components;

namespace A2UI.UnitTests.Services;

internal static class ComponentFactory
{
    internal static AudioPlayer CreateAudioPlayer() => new()
    {
        Url = new Uri("https://example.com/audio.mp3"),
        Description = "Sample Audio"
    };

    internal static Button CreateButton() => new()
    {
        Child = Guid.NewGuid().ToString("N"),
        Action = ButtonActionFactory.Create()
    };

    internal static Card CreateCard() => new()
    {
        Child = Guid.NewGuid().ToString("N")
    };

    internal static CheckBox CreateCheckBox() => new()
    {
        Label = DataModelReferenceFactory.Create(),
        Value = DataModelReferenceFactory.Create()
    };

    internal static ChoicePicker CreateChoicePicker() => new()
    {
        Label = DataModelReferenceFactory.Create(),
        Value = DataModelReferenceFactory.Create(),
        UsageHint = ChoicePickerUsageHint.MultipleSelection,
        Options =
        [
            ChoicePickerOptionFactory.Create(),
            ChoicePickerOptionFactory.Create(),
            ChoicePickerOptionFactory.Create()
        ]
    };

    internal static Column CreateColumn() => new()
    {
        Children = new string[]
        {
            Guid.NewGuid().ToString("N"),
            Guid.NewGuid().ToString("N"),
            Guid.NewGuid().ToString("N")
        },
        Alignment = Alignment.Center,
        Distribution = Distribution.SpaceAround
    };

    internal static DateTimeInput CreateDateTimeInput() => new()
    {
        Label = DataModelReferenceFactory.Create(),
        Value = DataModelReferenceFactory.Create(),
        EnableDate = true,
        EnableTime = false,
        OutputFormat = "yyyy-MM-dd"
    };

    internal static Divider CreateDivider() => new()
    {
        Axis = Direction.Horizontal
    };

    internal static Icon CreateIcon() => new()
    {
        Name = IconName.ArrowForward
    };

    internal static Image CreateImage() => new()
    {
        Url = new Uri("https://example.com/image.png"),
        Fit = ImageFit.Cover,
        UsageHint = ImageUsageHint.LargeFeature
    };

    internal static List CreateList() => new()
    {
        Children = new string[]
        {
            Guid.NewGuid().ToString("N"),
            Guid.NewGuid().ToString("N"),
            Guid.NewGuid().ToString("N")
        },
        Alignment = Alignment.End,
        Direction = Direction.Vertical
    };

    internal static Modal CreateModal() => new()
    {
        EntryPointChild = Guid.NewGuid().ToString("N"),
        ContentChild = Guid.NewGuid().ToString("N")
    };

    internal static Row CreateRow() => new()
    {
        Children = new string[]
        {
            Guid.NewGuid().ToString("N"),
            Guid.NewGuid().ToString("N"),
            Guid.NewGuid().ToString("N")
        },
        Alignment = Alignment.Start,
        Distribution = Distribution.SpaceBetween
    };

    internal static Slider CreateSlider() => new()
    {
        Label = DataModelReferenceFactory.Create(),
        Value = DataModelReferenceFactory.Create(),
        Min = 0,
        Max = 100,
    };

    internal static Tabs CreateTabs() => new()
    {
        TabItems =
        [
            TabFactory.Create(),
            TabFactory.Create(),
            TabFactory.Create()
        ]
    };

    internal static Text CreateText() => new()
    {
        Content = DataModelReferenceFactory.Create(),
        UsageHint = TextUsageHint.Body
    };

    internal static TextField CreateTextField() => new()
    {
        Label = DataModelReferenceFactory.Create(),
        Text = DataModelReferenceFactory.Create(),
        UsageHint = TextFieldUsageHint.LongText,
        ValidationRegex = "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$"
    };

    internal static Video CreateVideo() => new()
    {
        Url = new Uri("https://example.com/video.mp4")
    };

}
