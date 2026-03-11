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
/// Represents the input arguments for a <see cref="PluralizeFunctionCall" />.
/// </summary>
[Description("Represents the input arguments for a PluralizeFunctionCall.")]
[DataContract]
public sealed record PluralizeFunctionArgs
{

    /// <summary>
    /// Gets the numeric value used to determine the plural category.
    /// </summary>
    [Description("The numeric value used to determine the plural category.")]
    [DataMember(Order = 1, Name = "value"), JsonPropertyOrder(1), JsonPropertyName("value")]
    [JsonConverter(typeof(JsonOneOfConverter<DataBinding, FunctionCall, int>))]
    public required OneOf<DataBinding, FunctionCall, int> Value { get; init; }

    /// <summary>
    /// Gets the string for the zero category.
    /// </summary>
    [Description("The string for the zero category.")]
    [DataMember(Order = 2, Name = "zero"), JsonPropertyOrder(2), JsonPropertyName("zero")]
    [JsonConverter(typeof(JsonOneOfConverter<DataBinding, FunctionCall, string>))]
    public OneOf<DataBinding, FunctionCall, string>? Zero { get; init; }

    /// <summary>
    /// Gets the string for the one category.
    /// </summary>
    [Description("The string for the one category.")]
    [DataMember(Order = 3, Name = "one"), JsonPropertyOrder(3), JsonPropertyName("one")]
    [JsonConverter(typeof(JsonOneOfConverter<DataBinding, FunctionCall, string>))]
    public OneOf<DataBinding, FunctionCall, string>? One { get; init; }

    /// <summary>
    /// Gets the string for the two category.
    /// </summary>
    [Description("The string for the two category.")]
    [DataMember(Order = 4, Name = "two"), JsonPropertyOrder(4), JsonPropertyName("two")]
    [JsonConverter(typeof(JsonOneOfConverter<DataBinding, FunctionCall, string>))]
    public OneOf<DataBinding, FunctionCall, string>? Two { get; init; }

    /// <summary>
    /// Gets the string for the few category.
    /// </summary>
    [Description("The string for the few category.")]
    [DataMember(Order = 5, Name = "few"), JsonPropertyOrder(5), JsonPropertyName("few")]
    [JsonConverter(typeof(JsonOneOfConverter<DataBinding, FunctionCall, string>))]
    public OneOf<DataBinding, FunctionCall, string>? Few { get; init; }

    /// <summary>
    /// Gets the string for the many category.
    /// </summary>
    [Description("The string for the many category.")]
    [DataMember(Order = 6, Name = "many"), JsonPropertyOrder(6), JsonPropertyName("many")]
    [JsonConverter(typeof(JsonOneOfConverter<DataBinding, FunctionCall, string>))]
    public OneOf<DataBinding, FunctionCall, string>? Many { get; init; }

    /// <summary>
    /// Gets the fallback string for other plural categories.
    /// </summary>
    [Description("The fallback string for other plural categories.")]
    [DataMember(Order = 7, Name = "other"), JsonPropertyOrder(7), JsonPropertyName("other")]
    [JsonConverter(typeof(JsonOneOfConverter<DataBinding, FunctionCall, string>))]
    public required OneOf<DataBinding, FunctionCall, string> Other { get; init; }

}
