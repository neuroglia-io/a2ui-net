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
/// Enumerates all supported image usage hints.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ImageUsageHint>))]
public enum ImageUsageHint
{
    /// <summary>
    /// Indicates an icon image.
    /// </summary>
    [EnumMember(Value = "icon"), JsonStringEnumMemberName("icon")]
    Icon,

    /// <summary>
    /// Indicates an avatar image.
    /// </summary>
    [EnumMember(Value = "avatar"), JsonStringEnumMemberName("avatar")]
    Avatar,

    /// <summary>
    /// Indicates a small feature image.
    /// </summary>
    [EnumMember(Value = "smallFeature"), JsonStringEnumMemberName("smallFeature")]
    SmallFeature,

    /// <summary>
    /// Indicates a medium feature image.
    /// </summary>
    [EnumMember(Value = "mediumFeature"), JsonStringEnumMemberName("mediumFeature")]
    MediumFeature,

    /// <summary>
    /// Indicates a large feature image.
    /// </summary>
    [EnumMember(Value = "largeFeature"), JsonStringEnumMemberName("largeFeature")]
    LargeFeature,

    /// <summary>
    /// Indicates a header image.
    /// </summary>
    [EnumMember(Value = "header"), JsonStringEnumMemberName("header")]
    Header,
}






