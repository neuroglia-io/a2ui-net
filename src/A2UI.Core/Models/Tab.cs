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
/// Represents a single tab within a Tabs component.
/// </summary>
[Description("Represents a single tab within a Tabs component.")]
[DataContract]
public sealed record Tab
{

    /// <summary>
    /// Gets the tab's title.
    /// </summary>
    [Description("The tab's title.")]
    [Required]
    [DataMember(Order = 1, Name = "title"), JsonPropertyOrder(1), JsonPropertyName("title"), JsonConverter(typeof(JsonOneOfConverter<DataModelReference, string>))]
    public required OneOf<DataModelReference, string> Title { get; init; }

    /// <summary>
    /// Gets the unique identifier of the child component displayed within the tab.
    /// </summary>
    [Description("The unique identifier of the child component displayed within the tab.")]
    [Required]
    [DataMember(Order = 2, Name = "child"), JsonPropertyOrder(2), JsonPropertyName("child")]
    public required string Child { get; init; }

}