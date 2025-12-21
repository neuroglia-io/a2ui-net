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

namespace A2UI.Models;

/// <summary>
/// Represents a component used to display a checkbox.
/// </summary>
[Description("Represents a component used to display a checkbox.")]
[DataContract]
public sealed record CheckBox
    : Component
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore]
    public override string Type => ComponentType.CheckBox;

    /// <summary>
    /// Gets the text to display next to the checkbox.
    /// </summary>
    [Description("The text to display next to the checkbox.")]
    [Required]
    [DataMember(Order = 4, Name = "label"), JsonPropertyOrder(4), JsonPropertyName("label"), JsonConverter(typeof(JsonOneOfConverter<DataModelReference, string>))]
    public required OneOf<DataModelReference, string> Label { get; init; }

    /// <summary>
    /// Gets the current state of the checkbox (true for checked, false for unchecked)
    /// </summary>
    [Description("The current state of the checkbox (true for checked, false for unchecked)")]
    [Required]
    [DataMember(Order = 5, Name = "value"), JsonPropertyOrder(5), JsonPropertyName("value"), JsonConverter(typeof(JsonOneOfConverter<DataModelReference, bool>))]
    public required OneOf<DataModelReference, bool> Value { get; init; }

}