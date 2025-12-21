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
/// Enumerates all supported image fit modes.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ImageFit>))]
public enum ImageFit
{
    /// <summary>
    /// Indicates the image should be scaled to maintain its aspect ratio while fitting within the container.
    /// </summary>
    [EnumMember(Value = "contain"), JsonStringEnumMemberName("contain")]
    Contain,
    /// <summary>
    /// Indicates the image should be scaled to maintain its aspect ratio while filling the container, potentially cropping parts of the image.
    /// </summary>
    [EnumMember(Value = "cover"), JsonStringEnumMemberName("cover")]
    Cover,
    /// <summary>
    /// Indicates the image should be stretched to fill the container, disregarding its aspect ratio.
    /// </summary>
    [EnumMember(Value = "fill"), JsonStringEnumMemberName("fill")]
    Fill,
    /// <summary>
    /// Indicates the image should not be resized.
    /// </summary>
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    None,
    /// <summary>
    /// Indicates the image should be scaled down to fit within the container if it is larger, otherwise it should not be resized.
    /// </summary>
    [EnumMember(Value = "scale-down"), JsonStringEnumMemberName("scale-down")]
    ScaleDown,
}
