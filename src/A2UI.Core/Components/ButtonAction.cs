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
/// Represents a client-side action associated with a component.
/// </summary>
[Description("Represents a client-side action associated with a component.")]
[DataContract]
public sealed record ButtonAction
{

    /// <summary>
    /// Gets the action's name.
    /// </summary>
    [Description("The action's name.")]
    [Required]
    [DataMember(Order = 1, Name = "name"), JsonPropertyOrder(1), JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Gets a key/value mapping, if any, used for the action's context.
    /// </summary>
    [Description("A key/value mapping, if any, used for the action's context.")]
    [DataMember(Order = 2, Name = "context"), JsonPropertyOrder(2), JsonPropertyName("context")]
    public JsonObject? Context { get; init; }

}
