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
/// Represents a component used to display a text field.
/// </summary>
[Description("Represents a component used to display a text field.")]
[DataContract]
public sealed record TextField
    : Component
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore]
    public override string Type => ComponentType.TextField;

    /// <summary>
    /// Gets the text label for the input field.
    /// </summary>
    [Description("The text label for the input field.")]
    [Required]
    [DataMember(Order = 4, Name = "label"), JsonPropertyOrder(4), JsonPropertyName("label"), JsonConverter(typeof(JsonOneOfConverter<DataModelReference, string>))]
    public required OneOf<DataModelReference, string> Label { get; init; }

    /// <summary>
    /// Gets the value, if any, of the text field.
    /// </summary>
    [Description("The value, if any, of the text field.")]
    [DataMember(Order = 5, Name = "text"), JsonPropertyOrder(5), JsonPropertyName("text"), JsonConverter(typeof(JsonOneOfConverter<DataModelReference, string>))]
    public OneOf<DataModelReference, string>? Text { get; init; }

    /// <summary>
    /// Gets the type of input field to display.
    /// </summary>
    [Description("The type of input field to display.")]
    [DataMember(Order = 6, Name = "usageHint"), JsonPropertyOrder(6), JsonPropertyName("usageHint")]
    public TextFieldUsageHint? UsageHint { get; init; }

    /// <summary>
    /// Gets the regular expression, if any, used to validate the input.
    /// </summary>
    [Description("The regular expression, if any, used to validate the input.")]
    [DataMember(Order = 7, Name = "validationRegexp"), JsonPropertyOrder(7), JsonPropertyName("validationRegexp")]
    public string? ValidationRegex { get; init; }

}