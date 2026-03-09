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
/// Enumerates component distribution strategies.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<Justify>))]
public enum Justify
{
    /// <summary>
    /// Indicates center distribution.
    /// </summary>
    [EnumMember(Value = "center"), JsonStringEnumMemberName("center")]
    Center,
    /// <summary>
    /// Indicates end distribution.
    /// </summary>
    [EnumMember(Value = "end"), JsonStringEnumMemberName("end")]
    End,
    /// <summary>
    /// Indicates space around distribution.
    /// </summary>
    [EnumMember(Value = "spaceAround"), JsonStringEnumMemberName("spaceAround")]
    SpaceAround,
    /// <summary>
    /// Indicates space between distribution.
    /// </summary>
    [EnumMember(Value = "spaceBetween"), JsonStringEnumMemberName("spaceBetween")]
    SpaceBetween,
    /// <summary>
    /// Indicates space evenly distribution.
    /// </summary>
    [EnumMember(Value = "spaceEvenly"), JsonStringEnumMemberName("spaceEvenly")]
    SpaceEvenly,
    /// <summary>
    /// Indicates start distribution.
    /// </summary>
    [EnumMember(Value = "start"), JsonStringEnumMemberName("start")]
    Start,
    /// <summary>
    /// Indicates stretch distribution.
    /// </summary>
    [EnumMember(Value = "stretch"), JsonStringEnumMemberName("stretch")]
    Stretch,
}
