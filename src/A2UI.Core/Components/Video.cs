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
/// Represents a component used to display a video.
/// </summary>
[Description("Represents a component used to display a video.")]
[DataContract]
public sealed record Video
    : Component
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore]
    public override string Type => ComponentType.Video;

    /// <summary>
    /// Gets the URL of the video to display.
    /// </summary>
    [Description("The URL of the video to display.")]
    [Required]
    [DataMember(Order = 4, Name = "url"), JsonPropertyOrder(4), JsonPropertyName("url"), JsonConverter(typeof(JsonOneOfConverter<DataModelReference, Uri>))]
    public required OneOf<DataModelReference, Uri> Url { get; init; }

}

