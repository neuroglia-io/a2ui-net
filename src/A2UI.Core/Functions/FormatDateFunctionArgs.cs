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

namespace A2UI.Functions;

/// <summary>
/// Represents the input arguments for a <see cref="FormatDateFunctionCall" />.
/// </summary>
[Description("Represents the input arguments for a FormatDateFunctionCall.")]
[DataContract]
public sealed record FormatDateFunctionArgs
{

    /// <summary>
    /// Gets the date value to format.
    /// </summary>
    [Description("The date value to format.")]
    [DataMember(Order = 1, Name = "value"), JsonPropertyOrder(1), JsonPropertyName("value")]
    [JsonConverter(typeof(JsonOneOfConverter<DataBinding, FunctionCall, string>))]
    public required OneOf<DataBinding, FunctionCall, string> Value { get; init; }

    /// <summary>
    /// Gets the date format pattern.
    /// </summary>
    [Description("The date format pattern.")]
    [DataMember(Order = 2, Name = "format"), JsonPropertyOrder(2), JsonPropertyName("format")]
    [JsonConverter(typeof(JsonOneOfConverter<DataBinding, FunctionCall, string>))]
    public required OneOf<DataBinding, FunctionCall, string> Format { get; init; }

}
