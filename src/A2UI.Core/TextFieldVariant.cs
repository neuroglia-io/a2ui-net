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
/// Enumerates text field variants.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<TextFieldVariant>))]
public enum TextFieldVariant
{
    /// <summary>
    /// Indicates a long text input field.
    /// </summary>
    [EnumMember(Value = "longText"), JsonStringEnumMemberName("longText")]
    LongText,
    /// <summary>
    /// Indicates a numeric input field.
    /// </summary>
    [EnumMember(Value = "number"), JsonStringEnumMemberName("number")]
    Number,
    /// <summary>
    /// Indicates a short text input field.
    /// </summary>
    [EnumMember(Value = "shortText"), JsonStringEnumMemberName("shortText")]
    ShortText,
    /// <summary>
    /// Indicates an obscured input field.
    /// </summary>
    [EnumMember(Value = "obscured"), JsonStringEnumMemberName("obscured")]
    Obscured
}
