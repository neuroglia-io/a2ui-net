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
/// Enumerates the types of return values that can be expected from a function call.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<FunctionReturnType>))]
public enum FunctionReturnType
{
    /// <summary>
    /// Indicates that the function can return any type of value.
    /// </summary>
    [EnumMember(Value = "any"), JsonStringEnumMemberName("any")]
    Any,
    /// <summary>
    /// Indicates that the function returns an array of values.
    /// </summary>
    [EnumMember(Value = "array"), JsonStringEnumMemberName("array")]
    Array,
    /// <summary>
    /// Indicates that the function returns a boolean value.
    /// </summary>
    [EnumMember(Value = "boolean"), JsonStringEnumMemberName("boolean")]
    Boolean,
    /// <summary>
    /// Indicates that the function returns a numeric value.
    /// </summary>
    [EnumMember(Value = "number"), JsonStringEnumMemberName("number")]
    Number,
    /// <summary>
    /// Indicates that the function returns an object value.
    /// </summary>
    [EnumMember(Value = "object"), JsonStringEnumMemberName("object")]
    Object,
    /// <summary>
    /// Indicates that the function returns a string value.
    /// </summary>
    [EnumMember(Value = "string"), JsonStringEnumMemberName("string")]
    String,
    /// <summary>
    /// Indicates that the function does not return a value.
    /// </summary>
    [EnumMember(Value = "void"), JsonStringEnumMemberName("void")]
    Void
}