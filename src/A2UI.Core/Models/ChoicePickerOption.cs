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
/// Represents an option in a choice picker.
/// </summary>
[Description("Represents an option in a choice picker.")]
[DataContract]
public sealed record ChoicePickerOption
{

    /// <summary>
    /// Gets the text to display.
    /// </summary>
    [Description("The text to display.")]
    [Required]
    [DataMember(Order =1, Name = "label"), JsonPropertyOrder(1), JsonPropertyName("label"), JsonConverter(typeof(JsonOneOfConverter<DataModelReference, string>))]
    public required OneOf<DataModelReference, string> Label { get; init; }

    /// <summary>
    /// Gets the value associated with the option.
    /// </summary>
    [Description("The value associated with the option.")]
    [Required]
    [DataMember(Order = 2, Name = "value"), JsonPropertyOrder(2), JsonPropertyName("value"), JsonConverter(typeof(JsonOneOfConverter<DataModelReference, string>))]
    public required string Value { get; init; }

}