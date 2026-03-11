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
/// Represents a component that supports client-side checks.
/// </summary>
[Description("Represents a component that supports client-side checks.")]
[JsonPolymorphic(TypeDiscriminatorPropertyName = "component")]
[JsonDerivedType(typeof(Button), ComponentType.Button)]
[JsonDerivedType(typeof(CheckBox), ComponentType.CheckBox)]
[JsonDerivedType(typeof(ChoicePicker), ComponentType.ChoicePicker)]
[JsonDerivedType(typeof(DateTimeInput), ComponentType.DateTimeInput)]
[JsonDerivedType(typeof(Slider), ComponentType.Slider)]
[JsonDerivedType(typeof(TextField), ComponentType.TextField)]
[DataContract]
[KnownType(typeof(Button)), KnownType(typeof(CheckBox)), KnownType(typeof(ChoicePicker)), KnownType(typeof(DateTimeInput)), KnownType(typeof(Slider)), KnownType(typeof(TextField))]
public abstract record CheckableComponent
    : Component
{

    /// <summary>
    /// Gets a collection containing the checks, if any, to be performed on the client side.
    /// </summary>
    [Description("A collection containing the checks, if any, to be performed on the client side.")]
    [DataMember(Order = 999, Name = "checks"), JsonPropertyOrder(999), JsonPropertyName("checks")]
    public IReadOnlyCollection<CheckRule>? Checks { get; init; }

}