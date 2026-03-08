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
/// Represents the payload used to create a new surface within the A2UI application.
/// </summary>
[Description("Represents the payload used to create a new surface within the A2UI application.")]
[DataContract]
public sealed record CreateSurfaceMessagePayload
{

    /// <summary>
    /// Gets the unique identifier of the surface to create. This identifier is used to reference the surface in subsequent messages and interactions. It must be unique within the context of the application to avoid conflicts with existing surfaces.
    /// </summary>
    [Description("The unique identifier of the surface to create. This identifier is used to reference the surface in subsequent messages and interactions. It must be unique within the context of the application to avoid conflicts with existing surfaces.")]
    [Required, StringLength(int.MaxValue, MinimumLength = 1)]
    [DataMember(Order = 1, Name = "surfaceId"), JsonPropertyOrder(1), JsonPropertyName("surfaceId")]
    public required string SurfaceId { get; init; }

    /// <summary>
    /// Gets the unique identifier of the component catalog used to populate the surface. This identifier is used to reference the component catalog that contains the components to be displayed on the surface. It must correspond to a valid component catalog that has been registered with the application.
    /// </summary>
    [Description("The unique identifier of the component catalog used to populate the surface. This identifier is used to reference the component catalog that contains the components to be displayed on the surface. It must correspond to a valid component catalog that has been registered with the application.")]
    [Required, StringLength(int.MaxValue, MinimumLength = 1)]
    [DataMember(Order = 2, Name = "catalogId"), JsonPropertyOrder(2), JsonPropertyName("catalogId")]
    public required string CatalogId { get; init; }

    /// <summary>
    /// Gets the theme, if any, to apply to the surface. The theme can be used to customize the appearance of the surface and its components. It may include properties such as colors, fonts, and other visual styles that can be applied to the surface and its child components to create a cohesive and visually appealing user interface.
    /// </summary>
    [Description("The theme, if any, to apply to the surface. The theme can be used to customize the appearance of the surface and its components. It may include properties such as colors, fonts, and other visual styles that can be applied to the surface and its child components to create a cohesive and visually appealing user interface.")]
    [DataMember(Order = 3, Name = "theme"), JsonPropertyOrder(3), JsonPropertyName("theme")]
    public Theme? Theme { get; init; }

    /// <summary>
    /// Gets a boolean indicating whether the client should send data model updates to the surface.
    /// </summary>
    [Description("A boolean indicating whether the client should send data model updates to the surface.")]
    [DataMember(Order = 4, Name = "sendDataModel"), JsonPropertyOrder(4), JsonPropertyName("sendDataModel")]
    public bool SendDataModel { get; init; }

}
