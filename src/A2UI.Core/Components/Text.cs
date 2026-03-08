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
/// Represents a component used to display text.
/// </summary>
[Description("Represents a component used to display text.")]
[DataContract]
public sealed record Text
    : Component
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore]
    public override string Type => ComponentType.Text;

    /// <summary>
    /// Gets the text content to display. While simple Markdown formatting is supported (i.e. without HTML, images, or links), utilizing dedicated UI components is generally preferred for a richer and more structured presentation.
    /// </summary>
    [Description("The text content to display. While simple Markdown formatting is supported (i.e. without HTML, images, or links), utilizing dedicated UI components is generally preferred for a richer and more structured presentation.")]
    [Required]
    [DataMember(Order = 4, Name = "text"), JsonPropertyOrder(4), JsonPropertyName("text"), JsonConverter(typeof(JsonOneOfConverter<DataModelReference, string>))]
    public required OneOf<DataModelReference, string> Content { get; init; }

    /// <summary>
    /// Gets a hint, if any, for the base text style.
    /// </summary>
    [Description("A hint, if any, for the base text style.")]
    [DataMember(Order = 5, Name = "usageHint"), JsonPropertyOrder(5), JsonPropertyName("usageHint")]
    public TextUsageHint? UsageHint { get; init; }

}
