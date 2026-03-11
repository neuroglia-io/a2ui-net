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
/// Represents a function call that checks whether a value is a valid email address.
/// </summary>
[Description("Checks that the value is a valid email address.")]
[DataContract]
public sealed record EmailFunctionCall
    : FunctionCall<EmailFunctionArgs>
{

    /// <summary>
    /// Gets the name of the function.
    /// </summary>
    public const string FunctionName = "email";

    /// <summary>
    /// Initializes a new <see cref="EmailFunctionCall" />.
    /// </summary>
    [SetsRequiredMembers]
    public EmailFunctionCall(EmailFunctionArgs arguments)
    {
        Call = FunctionName;
        ReturnType = FunctionReturnType.Boolean;
        Arguments = arguments;
    }

    /// <summary>
    /// Gets the JSON type information for the function's arguments.
    /// </summary>
    [JsonIgnore]
    protected override JsonTypeInfo<EmailFunctionArgs> ArgumentsTypeInfo => JsonSerializationContext.Default.EmailFunctionArgs;

}
