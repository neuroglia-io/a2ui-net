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

namespace A2UI;

/// <summary>
/// Represents a user-initiated action from a component..
/// </summary>
[Description("Represents a user-initiated action from a component..")]
[DataContract]
public sealed record ClientSideAction
{

    /// <summary>
    /// Gets the action's name.
    /// </summary>
    [Description("The action's name.")]
    [Required, StringLength(int.MaxValue, MinimumLength = 1)]
    [DataMember(Order = 1, Name = "name"), JsonPropertyOrder(1), JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Gets the unique identifier of the surface from which the action was triggered.
    /// </summary>
    [Description("The unique identifier of the surface from which the action was triggered.")]
    [Required, StringLength(int.MaxValue, MinimumLength = 1)]
    [DataMember(Order = 2, Name = "surfaceId"), JsonPropertyOrder(2), JsonPropertyName("surfaceId")]
    public required string SurfaceId { get; init; }

    /// <summary>
    /// Gets the unique identifier of the component that triggered the action.
    /// </summary>
    [Description("The unique identifier of the component that triggered the action.")]
    [Required, StringLength(int.MaxValue, MinimumLength = 1)]
    [DataMember(Order = 3, Name = "sourceComponentId"), JsonPropertyOrder(3), JsonPropertyName("sourceComponentId")]
    public required string SourceComponentId { get; init; }

    /// <summary>
    /// Gets the date and time at which the action occurred.
    /// </summary>
    [Description("The date and time at which the action occurred.")]
    [DataMember(Order = 4, Name = "timestamp"), JsonPropertyOrder(4), JsonPropertyName("timestamp")]
    public required DateTime Timestamp { get; init; }

    /// <summary>
    /// Gets contextual information about the action.
    /// </summary>
    [Description("Contextual information about the action.")]
    [Required]
    [DataMember(Order = 5, Name = "context"), JsonPropertyOrder(5), JsonPropertyName("context")]
    public required JsonObject Context { get; init; }

}
