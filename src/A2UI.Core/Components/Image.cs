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
/// Represents a component used to display an image.
/// </summary>
[Description("Represents a component used to display an image.")]
[DataContract]
public sealed record Image
    : Component
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore]
    public override string Type => ComponentType.Image;

    /// <summary>
    /// Gets the URL of the image to display.
    /// </summary>
    [Description("The URL of the image to display.")]
    [Required]
    [DataMember(Order = 4, Name = "url"), JsonPropertyOrder(4), JsonPropertyName("url"), JsonConverter(typeof(JsonOneOfConverter<DataBinding, FunctionCall, Uri>))]
    public required OneOf<DataBinding, FunctionCall, Uri> Url { get; init; }

    /// <summary>
    /// Gets a value used to specify how the image should be resized to fit its container.
    /// </summary>
    [Description("A value used to specify how the image should be resized to fit its container.")]
    [DataMember(Order = 5, Name = "fit"), JsonPropertyOrder(5), JsonPropertyName("fit")]
    public ImageFit? Fit { get; init; }

    /// <summary>
    /// Gets a hint, if any, for the image size and style.
    /// </summary>
    [Description("A hint, if any, for the image size and style.")]
    [DataMember(Order = 6, Name = "variant"), JsonPropertyOrder(6), JsonPropertyName("variant")]
    public ImageVariant? Variant { get; init; }

}