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

namespace A2UI.Components;

/// <summary>
/// Represents a component used to display a choice picker.
/// </summary>
[Description("Represents a component used to display a choice picker.")]
[DataContract]
public sealed record ChoicePicker
    : Component
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore]
    public override string Type => ComponentType.ChoicePicker;

    /// <summary>
    /// Gets the text to display next to the choice picker.
    /// </summary>
    [Description("The text to display next to the choice picker.")]
    [Required]
    [DataMember(Order = 4, Name = "label"), JsonPropertyOrder(4), JsonPropertyName("label"), JsonConverter(typeof(JsonOneOfConverter<DataModelReference, string>))]
    public required OneOf<DataModelReference, string> Label { get; init; }

    /// <summary>
    /// Gets an hint for how the choice picker should be displayed and behave.
    /// </summary>
    [Description("An hint for how the choice picker should be displayed and behave.")]
    [Required]
    [DataMember(Order = 5, Name = "usageHint"), JsonPropertyOrder(5), JsonPropertyName("usageHint")]
    public required ChoicePickerUsageHint UsageHint { get; init; }

    /// <summary>
    /// Gets a collection containing the options available in the choice picker.
    /// </summary>
    [Description("A collection containing the options available in the choice picker.")]
    [Required]
    [DataMember(Order = 6, Name = "options"), JsonPropertyOrder(6), JsonPropertyName("options")]
    public required IReadOnlyCollection<ChoicePickerOption> Options { get; init; }

    /// <summary>
    /// Gets the list of currently selected values. This should be bound to a string array in the data model.
    /// </summary>
    [Description("The list of currently selected values. This should be bound to a string array in the data model.")]
    [Required]
    [DataMember(Order = 7, Name = "value"), JsonPropertyOrder(7), JsonPropertyName("value"), JsonConverter(typeof(JsonOneOfConverter<DataModelReference, string[]>))]
    public required OneOf<DataModelReference, string[]> Value { get; init; }

}
