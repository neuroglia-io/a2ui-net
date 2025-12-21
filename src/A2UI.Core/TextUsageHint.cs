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
/// Enumerates all supported text usage hints.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<TextUsageHint>))]
public enum TextUsageHint
{
    /// <summary>
    /// Indicates a top-level header text.
    /// </summary>
    [EnumMember(Value = "h1"), JsonStringEnumMemberName("h1")]
    H1,
    /// <summary>
    /// Indicates a second-level header text.
    /// </summary>
    [EnumMember(Value = "h2"), JsonStringEnumMemberName("h2")]
    H2,
    /// <summary>
    /// Indicates a third-level header text.
    /// </summary>
    [EnumMember(Value = "h3"), JsonStringEnumMemberName("h3")]
    H3,
    /// <summary>
    /// Indicates a fourth-level header text.
    /// </summary>
    [EnumMember(Value = "h4"), JsonStringEnumMemberName("h4")]
    H4,
    /// <summary>
    /// Indicates a fifth-level header text.
    /// </summary>
    [EnumMember(Value = "h5"), JsonStringEnumMemberName("h5")]
    H5,
    /// <summary>
    /// Indicates a caption text.
    /// </summary>
    [EnumMember(Value = "caption"), JsonStringEnumMemberName("caption")]
    Caption,
    /// <summary>
    /// Indicates a body text.
    /// </summary>
    [EnumMember(Value = "body"), JsonStringEnumMemberName("body")]
    Body
}
