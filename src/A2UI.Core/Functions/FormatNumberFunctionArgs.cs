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
/// Represents the input arguments for a <see cref="FormatNumberFunctionCall" />.
/// </summary>
[Description("Represents the input arguments for a FormatNumberFunctionCall.")]
[DataContract]
public sealed record FormatNumberFunctionArgs
{

    /// <summary>
    /// Gets the numeric value to format.
    /// </summary>
    [Description("The numeric value to format.")]
    [DataMember(Order = 1, Name = "value"), JsonPropertyOrder(1), JsonPropertyName("value")]
    [JsonConverter(typeof(JsonOneOfConverter<DataBinding, FunctionCall, decimal>))]
    public required OneOf<DataBinding, FunctionCall, decimal> Value { get; init; }

    /// <summary>
    /// Gets the number of decimal places to show.
    /// </summary>
    [Description("The number of decimal places to show.")]
    [DataMember(Order = 2, Name = "decimals"), JsonPropertyOrder(2), JsonPropertyName("decimals")]
    [JsonConverter(typeof(JsonOneOfConverter<DataBinding, FunctionCall, uint>))]
    public OneOf<DataBinding, FunctionCall, uint>? Decimals { get; init; }

    /// <summary>
    /// Gets a value indicating whether grouping separators should be used.
    /// </summary>
    [Description("A value indicating whether grouping separators should be used.")]
    [DataMember(Order = 3, Name = "grouping"), JsonPropertyOrder(3), JsonPropertyName("grouping")]
    [JsonConverter(typeof(JsonOneOfConverter<DataBinding, FunctionCall, bool>))]
    public OneOf<DataBinding, FunctionCall, bool>? Grouping { get; init; }

}
