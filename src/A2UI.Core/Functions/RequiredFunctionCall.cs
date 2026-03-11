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
/// Represents a function call that requires specific arguments to be provided.
/// </summary>
[Description("Represents a function call that requires specific arguments to be provided.")]
[DataContract]
public sealed record RequiredFunctionCall
    : FunctionCall<RequiredFunctionArgs>
{

    /// <summary>
    /// Gets the function's name.
    /// </summary>
    public const string FunctionName = "required";

    /// <summary>
    /// Initializes a new <see cref="RequiredFunctionCall"/>.
    /// </summary>
    public RequiredFunctionCall()
    {
        Call = FunctionName;
        ReturnType = FunctionReturnType.Boolean;
    }

    /// <inheritdoc/>
    [JsonIgnore]
    protected override JsonTypeInfo<RequiredFunctionArgs> ArgumentsTypeInfo => throw new NotImplementedException();

}
