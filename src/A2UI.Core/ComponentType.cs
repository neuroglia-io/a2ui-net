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

namespace A2UI;

/// <summary>
/// Enumerates all supported component types.
/// </summary>
public static class ComponentType
{

    /// <summary>
    /// Indicates a component used to play audio.
    /// </summary>
    public const string AudioPlayer = "AudioPlayer";
    /// <summary>
    /// Indicates a component used to display a button.
    /// </summary>
    public const string Button = "Button";
    /// <summary>
    /// Indicates a component used to display a card.
    /// </summary>
    public const string Card = "Card";
    /// <summary>
    /// Indicates a component used to display a checkbox.
    /// </summary>
    public const string CheckBox = "CheckBox";
    /// <summary>
    /// Indicates a component used to display a choice picker.
    /// </summary>
    public const string ChoicePicker = "ChoicePicker";
    /// <summary>
    /// Indicates a component used to arrange other components in a column.
    /// </summary>
    public const string Column = "Column";
    /// <summary>
    /// Indicates a component used to display a date and time input.
    /// </summary>
    public const string DateTimeInput = "DateTimeInput";
    /// <summary>
    /// Indicates a component used to display a divider.
    /// </summary>
    public const string Divider = "Divider";
    /// <summary>
    /// Indicates a component used to display an icon.
    /// </summary>
    public const string Icon = "Icon";
    /// <summary>
    /// Indicates a component used to display an image.
    /// </summary>
    public const string Image = "Image";
    /// <summary>
    /// Indicates a component used to display a list of other components.
    /// </summary>
    public const string List = "List";
    /// <summary>
    /// Indicates a component used to display a modal.
    /// </summary>
    public const string Modal = "Modal";
    /// <summary>
    /// Indicates a component used to arrange other components in a row.
    /// </summary>
    public const string Row = "Row";
    /// <summary>
    /// Indicates a component used to display a slider.
    /// </summary>
    public const string Slider = "Slider";
    /// <summary>
    /// Indicates a component used to display tabs.
    /// </summary>
    public const string Tabs = "Tabs";
    /// <summary>
    /// Indicates a component used to display text.
    /// </summary>
    public const string Text = "Text";
    /// <summary>
    /// Indicates a component used to display a text field.
    /// </summary>
    public const string TextField = "TextField";
    /// <summary>
    /// Indicates a component used to display video.
    /// </summary>
    public const string Video = "Video";

    /// <summary>
    /// Gets all supported component types.
    /// </summary>
    public static readonly IEnumerable<string> All =
    [
        AudioPlayer,
        Button,
        Card,
        CheckBox,
        ChoicePicker,
        Column,
        DateTimeInput,
        Divider,
        Icon,
        Image,
        List,
        Modal,
        Row,
        Slider,
        Tabs,
        Text,
        TextField,
        Video
    ];

}
