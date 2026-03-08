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
/// Represents theming information for the UI.
/// </summary>
[Description("Represents theming information for the UI.")]
[DataContract]
public sealed record Theme
{

    /// <summary>
    /// Gets the primary font, if any, for the UI.
    /// </summary>
    [Description("The primary font, if any, for the UI.")]
    [DataMember(Order = 1, Name = "font"), JsonPropertyOrder(1), JsonPropertyName("font")]
    public string? Font { get; init; }

    /// <summary>
    /// Gets the primary color, if any, for the UI.
    /// </summary>
    [Description("The primary color, if any, for the UI.")]
    [DataMember(Order = 2, Name = "primaryColor"), JsonPropertyOrder(2), JsonPropertyName("primaryColor")]
    public string? PrimaryColor { get; init; }

    /// <summary>
    /// Gets a key/value map of additional theming information, if any, that can be used by the UI. This allows for extensibility and customization of the theme beyond the predefined properties. The keys in the map should be descriptive and indicate the purpose of the theming information they represent, while the values can be any valid JSON element that provides the necessary data for the theme customization.
    /// </summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? ExtensionData { get; set; }

}
