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

namespace A2UI;

/// <summary>
/// Represents an UI component.
/// </summary>
[Description("Represents an UI component.")]
[JsonPolymorphic(TypeDiscriminatorPropertyName = "component")]
[JsonDerivedType(typeof(AudioPlayer), ComponentType.AudioPlayer)]
[JsonDerivedType(typeof(Card), ComponentType.Card)]
[JsonDerivedType(typeof(Button), ComponentType.Button)]
[JsonDerivedType(typeof(CheckBox), ComponentType.CheckBox)]
[JsonDerivedType(typeof(ChoicePicker), ComponentType.ChoicePicker)]
[JsonDerivedType(typeof(DateTimeInput), ComponentType.DateTimeInput)]
[JsonDerivedType(typeof(Slider), ComponentType.Slider)]
[JsonDerivedType(typeof(TextField), ComponentType.TextField)]
[JsonDerivedType(typeof(Column), ComponentType.Column)]
[JsonDerivedType(typeof(Divider), ComponentType.Divider)]
[JsonDerivedType(typeof(Icon), ComponentType.Icon)]
[JsonDerivedType(typeof(Image), ComponentType.Image)]
[JsonDerivedType(typeof(List), ComponentType.List)]
[JsonDerivedType(typeof(Modal), ComponentType.Modal)]
[JsonDerivedType(typeof(Row), ComponentType.Row)]
[JsonDerivedType(typeof(Tabs), ComponentType.Tabs)]
[JsonDerivedType(typeof(Text), ComponentType.Text)]
[JsonDerivedType(typeof(Video), ComponentType.Video)]
[DataContract]
[KnownType(typeof(Card)), KnownType(typeof(Column)), KnownType(typeof(Divider)), KnownType(typeof(Icon))]
[KnownType(typeof(Image)), KnownType(typeof(List)), KnownType(typeof(Modal)), KnownType(typeof(Row))]
[KnownType(typeof(Tabs)), KnownType(typeof(Text)), KnownType(typeof(Video))]
public abstract record Component
{

    /// <summary>
    /// Gets the component's type.
    /// </summary>
    [Description("The component's type.")]
    [IgnoreDataMember, JsonIgnore]
    public abstract string Type { get; }

    /// <summary>
    /// Gets the component's unique identifier.
    /// </summary>
    [Description("The component's unique identifier.")]
    [Required]
    [DataMember(Order = 2, Name = "id"), JsonPropertyOrder(2), JsonPropertyName("id")]
    public string Id { get; init; } = Guid.NewGuid().ToString("N");

    /// <summary>
    /// Gets the relative weight of the component, if any, used for layout purposes.
    /// </summary>
    [Description("The relative weight of the component, if any, used for layout purposes.")]
    [DataMember(Order = 3, Name = "weight"), JsonPropertyOrder(3), JsonPropertyName("weight")]
    public int? Weight { get; init; }

    /// <summary>
    /// Gets attributes, if any, to enhance accessibility when using assistive technologies like screen readers.
    /// </summary>
    [Description("Attributes, if any, to enhance accessibility when using assistive technologies like screen readers.")]
    [DataMember(Order = 998, Name = "accessibility"), JsonPropertyOrder(998), JsonPropertyName("accessibility")]
    public AccessibilityAttributes? Accessibility { get; init; }

}
