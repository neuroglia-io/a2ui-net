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
/// Represents a single validation rule applied to an input component.
/// </summary>
[Description("Represents a single validation rule applied to an input component.")]
[DataContract]
public sealed record CheckRule
{

    /// <summary>
    /// Gets the condition to check, which can be a boolean expression or a reference to a function that evaluates the condition.
    /// </summary>
    [Description("The condition to check, which can be a boolean expression or a reference to a function that evaluates the condition.")]
    [DataMember(Order = 1, Name = "condition"), JsonPropertyOrder(1), JsonPropertyName("condition"), JsonConverter(typeof(JsonOneOfConverter<DataBinding, FunctionCall, bool>))]
    public required OneOf<DataBinding, FunctionCall, bool> Condition { get; init; }

    /// <summary>
    /// Gets the error message to display if the check fails.
    /// </summary>
    [Description("The error message to display if the check fails.")]
    [DataMember(Order = 2, Name = "message"), JsonPropertyOrder(2), JsonPropertyName("message")]
    public required string Message { get; init; }

}
