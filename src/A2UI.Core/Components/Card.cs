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
/// Represents a component used to display content inside a card layout.
/// </summary>
[Description("Represents a component used to display content inside a card layout.")]
[DataContract]
public sealed record Card
    : Component
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore]
    public override string Type => ComponentType.Card;

    /// <summary>
    /// Gets the unique identifier of the child component contained inside the card. To display multiple elements, you MUST wrap them in a layout component (like Column or Row) and pass that container's ID here.
    /// </summary>
    [Description("The unique identifier of the child component contained inside the card. To display multiple elements, you MUST wrap them in a layout component (like Column or Row) and pass that container's ID here.")]
    [Required]
    [DataMember(Order = 4, Name = "child"), JsonPropertyOrder(4), JsonPropertyName("child")]
    public required string Child { get; init; }

}
