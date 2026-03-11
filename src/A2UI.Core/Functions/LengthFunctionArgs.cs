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
/// Represents the input arguments for a <see cref="LengthFunctionCall" />.
/// </summary>
[Description("Represents the input arguments for a LengthFunctionCall.")]
[DataContract]
public sealed record LengthFunctionArgs
{

    /// <summary>
    /// Gets the string value to evaluate.
    /// </summary>
    [Description("The string value to evaluate.")]
    [DataMember(Order = 1, Name = "value"), JsonPropertyOrder(1), JsonPropertyName("value")]
    [JsonConverter(typeof(JsonOneOfConverter<DataBinding, FunctionCall, string>))]
    public required OneOf<DataBinding, FunctionCall, string> Value { get; init; }

    /// <summary>
    /// Gets the minimum allowed length.
    /// </summary>
    [Description("The minimum allowed length.")]
    [DataMember(Order = 2, Name = "min"), JsonPropertyOrder(2), JsonPropertyName("min")]
    public uint? Min { get; init; }

    /// <summary>
    /// Gets the maximum allowed length.
    /// </summary>
    [Description("The maximum allowed length.")]
    [DataMember(Order = 3, Name = "max"), JsonPropertyOrder(3), JsonPropertyName("max")]
    public uint? Max { get; init; }

}
