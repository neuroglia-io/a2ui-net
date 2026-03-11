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
/// Represents a component used to display a slider.
/// </summary>
[Description("Represents a component used to display a slider.")]
[DataContract]
public sealed record Slider
    : CheckableComponent
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore]
    public override string Type => ComponentType.Slider;

    /// <summary>
    /// Gets the text to display next to the slider.
    /// </summary>
    [Description("The text to display next to the slider.")]
    [Required]
    [DataMember(Order = 4, Name = "label"), JsonPropertyOrder(4), JsonPropertyName("label"), JsonConverter(typeof(JsonOneOfConverter<DataBinding, FunctionCall, string>))]
    public required OneOf<DataBinding, FunctionCall, string> Label { get; init; }

    /// <summary>
    /// Gets the minimum value, if any, for the slider.
    /// </summary>
    [Description("The minimum value, if any, for the slider.")]
    [DataMember(Order = 5, Name = "min"), JsonPropertyOrder(5), JsonPropertyName("min")]
    public int? Min { get; init; }

    /// <summary>
    /// Gets the maximum value, if any, for the slider.
    /// </summary>
    [Description("The maximum value, if any, for the slider.")]
    [DataMember(Order = 6, Name = "max"), JsonPropertyOrder(6), JsonPropertyName("max")]
    public int? Max { get; init; }

    /// <summary>
    /// Gets the current value of the slider.
    /// </summary>
    [Description("The current value of the slider.")]
    [Required]
    [DataMember(Order = 7, Name = "value"), JsonPropertyOrder(7), JsonPropertyName("value"), JsonConverter(typeof(JsonOneOfConverter<DataBinding, FunctionCall, int>))]
    public required OneOf<DataBinding, FunctionCall, int> Value { get; init; }

}