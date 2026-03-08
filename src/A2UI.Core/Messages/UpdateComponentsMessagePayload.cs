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

namespace A2UI.Messages;

/// <summary>
/// Represents the payload used to update components on an existing surface within the A2UI application.
/// </summary>
[Description("Represents the payload used to update components on an existing surface within the A2UI application.")]
[DataContract]
public sealed record UpdateComponentsMessagePayload
{

    /// <summary>
    /// Gets the unique identifier of the surface to update. It must correspond to a valid surface that has been previously created in the application.
    /// </summary>
    [Description("The unique identifier of the surface to update. It must correspond to a valid surface that has been previously created in the application.")]
    [Required, StringLength(int.MaxValue, MinimumLength = 1)]
    [DataMember(Order = 1, Name = "surfaceId"), JsonPropertyOrder(1), JsonPropertyName("surfaceId")]
    public required string SurfaceId { get; init; }

    /// <summary>
    /// Gets the collection of components that will be updated on the surface.
    /// </summary>
    [Description("The components to update on the surface.")]
    [DataMember(Order = 2, Name = "components"), JsonPropertyOrder(2), JsonPropertyName("components")]
    public required IEnumerable<Component> Components { get; init; }

}