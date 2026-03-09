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
/// Enumerates button variants.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ButtonVariant>))]
public enum ButtonVariant
{
    /// <summary>
    /// Indicates the default button style.
    /// </summary>
    [EnumMember(Value = "default"), JsonStringEnumMemberName("default")]
    Default,
    /// <summary>
    /// Indicates a primary button, which is typically the main call to action.
    /// </summary>
    [EnumMember(Value = "primary"), JsonStringEnumMemberName("primary")]
    Primary,
    /// <summary>
    /// Indicates a borderless button, which is a button that has no visual border or background, making its child content appear like a clickable link
    /// </summary>
    [EnumMember(Value = "borderless"), JsonStringEnumMemberName("borderless")]
    Borderless
}