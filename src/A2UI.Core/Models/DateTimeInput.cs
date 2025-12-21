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
/// Represents a component used to display a date and time input.
/// </summary>
[Description("Represents a component used to display a date and time input.")]
[DataContract]
public sealed record DateTimeInput
    : Component
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore]
    public override string Type => ComponentType.DateTimeInput;

    /// <summary>
    /// Gets the selected date and/or time value in ISO 8601 format. If not yet set, initialize with an empty string.
    /// </summary>
    [Description("The selected date and/or time value in ISO 8601 format. If not yet set, initialize with an empty string.")]
    [Required]
    [DataMember(Order = 4, Name = "value"), JsonPropertyOrder(4), JsonPropertyName("value"), JsonConverter(typeof(JsonOneOfConverter<DataModelReference, string>))]
    public required OneOf<DataModelReference, string> Value { get; init; }

    /// <summary>
    /// Gets a boolean indicating whether the input allows selecting a date.
    /// </summary>
    [Description("A boolean indicating whether the input allows selecting a date.")]
    [DataMember(Order = 5, Name = "enableDate"), JsonPropertyOrder(5), JsonPropertyName("enableDate")]
    public bool? EnableDate { get; init; }

    /// <summary>
    /// Gets a boolean indicating whether the input allows selecting a time.
    /// </summary>
    [Description("A boolean indicating whether the input allows selecting a time.")]
    [DataMember(Order = 6, Name = "enableTime"), JsonPropertyOrder(6), JsonPropertyName("enableTime")]
    public bool? EnableTime { get; init; }

    /// <summary>
    /// Gets the desired output format, if any, for the date and/or time value.
    /// </summary>
    [Description("The desired output format, if any, for the date and/or time value.")]
    [DataMember(Order = 7, Name = "outputFormat"), JsonPropertyOrder(7), JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; init; }

    /// <summary>
    /// Gets the text label for the input field.
    /// </summary>
    [Description("The text label for the input field.")]
    [DataMember(Order = 8, Name = "label"), JsonPropertyOrder(8), JsonPropertyName("label"), JsonConverter(typeof(JsonOneOfConverter<DataModelReference, string>))]
    public OneOf<DataModelReference, string>? Label { get; init; }

}