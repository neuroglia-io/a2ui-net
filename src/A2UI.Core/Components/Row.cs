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
/// Represents a component used to arrange other components in a row.
/// </summary>
[Description("Represents a component used to arrange other components in a row.")]
[DataContract]
public sealed record Row
    : Component
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore]
    public override string Type => ComponentType.Row;

    /// <summary>
    /// Gets the child components the row contains.
    /// </summary>
    [Description("The child components the row contains.")]
    [Required]
    [DataMember(Order = 4, Name = "children"), JsonPropertyOrder(4), JsonPropertyName("children"), JsonConverter(typeof(JsonOneOfConverter<ComponentTemplate, string[]>))]
    public required OneOf<ComponentTemplate, string[]> Children { get; init; }

    /// <summary>
    /// Gets the distribution strategy, if any, used to arrange children along the main axis (horizontally).
    /// </summary>
    [Description("The distribution strategy, if any, used to arrange children along the main axis (horizontally).")]
    [DataMember(Order = 5, Name = "distribution"), JsonPropertyOrder(5), JsonPropertyName("distribution")]
    public Distribution? Distribution { get; init; }

    /// <summary>
    /// Gets the alignment strategy, if any, used to align children along the cross axis (vertically).
    /// </summary>
    [Description("The alignment strategy, if any, used to align children along the cross axis (vertically).")]
    [DataMember(Order = 6, Name = "alignment"), JsonPropertyOrder(6), JsonPropertyName("alignment")]
    public Alignment? Alignment { get; init; }

}
