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
/// Represents a component used to display a button.
/// </summary>
[Description("Represents a component used to display a button.")]
[DataContract]
public sealed record Button
    : Component
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore]
    public override string Type => ComponentType.Button;

    /// <summary>
    /// Gets the unique identifier of the child component contained within the button.
    /// </summary>
    [Description("The unique identifier of the child component contained within the button.")]
    [Required]
    [DataMember(Order = 4, Name = "child"), JsonPropertyOrder(4), JsonPropertyName("child")]
    public required string Child { get; init; }

    /// <summary>
    /// Gets a boolean indicating whether the button should be styled as the primary action.
    /// </summary>
    [Description("A boolean indicating whether the button should be styled as the primary action.")]
    [DataMember(Order = 5, Name = "primary"), JsonPropertyOrder(5), JsonPropertyName("primary")]
    public bool? Primary { get; init; }

    /// <summary>
    /// Gets the client-side action to be dispatched when the button is clicked.
    /// </summary>
    [Description("The client-side action to be dispatched when the button is clicked.")]
    [Required]
    [DataMember(Order = 6, Name = "action"), JsonPropertyOrder(6), JsonPropertyName("action")]
    public required ButtonAction Action { get; init; }

}
