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
/// Represents a function call that performs a logical NOT operation on a boolean value.
/// </summary>
[Description("Performs a logical NOT operation on a boolean value.")]
[DataContract]
public sealed record NotFunctionCall
    : FunctionCall<NotFunctionArgs>
{

    /// <summary>
    /// Gets the name of the function.
    /// </summary>
    public const string FunctionName = "not";

    /// <summary>
    /// Initializes a new <see cref="NotFunctionCall" />.
    /// </summary>
    public NotFunctionCall()
    {
        Call = FunctionName;
        ReturnType = FunctionReturnType.Boolean;
    }

    /// <summary>
    /// Gets the JSON type information for the function's arguments.
    /// </summary>
    [JsonIgnore]
    protected override JsonTypeInfo<NotFunctionArgs> ArgumentsTypeInfo => JsonSerializationContext.Default.NotFunctionArgs;

}
