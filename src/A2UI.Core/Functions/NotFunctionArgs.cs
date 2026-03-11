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
/// Represents the input arguments for a <see cref="NotFunctionCall" />.
/// </summary>
[Description("Represents the input arguments for a NotFunctionCall.")]
[DataContract]
public sealed record NotFunctionArgs
{

    /// <summary>
    /// Gets the boolean value to negate.
    /// </summary>
    [Description("The boolean value to negate.")]
    [DataMember(Order = 1, Name = "value"), JsonPropertyOrder(1), JsonPropertyName("value")]
    [JsonConverter(typeof(JsonOneOfConverter<DataBinding, FunctionCall, bool>))]
    public required OneOf<DataBinding, FunctionCall, bool> Value { get; init; }

}