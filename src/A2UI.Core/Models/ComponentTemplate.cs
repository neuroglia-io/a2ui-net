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
/// Represents a template for creating multiple instances of a component based on data.
/// </summary>
[Description("Represents a template for creating multiple instances of a component based on data.")]
[DataContract]
public sealed record ComponentTemplate
{

    /// <summary>
    /// Gets the unique identifier of the component to use as a template.
    /// </summary>
    [Description("The unique identifier of the component to use as a template.")]
    [Required]
    [DataMember(Order = 1, Name = "componentId"), JsonPropertyOrder(1), JsonPropertyName("componentId")]
    public required string ComponentId { get; init; }

    /// <summary>
    /// Gets the path to the data model property to bind to the template.
    /// </summary>
    [Description("The path to the data model property to bind to the template.")]
    [Required]
    [DataMember(Order = 2, Name = "path"), JsonPropertyOrder(2), JsonPropertyName("path")]
    public required JsonPointer Path { get; init; }

}