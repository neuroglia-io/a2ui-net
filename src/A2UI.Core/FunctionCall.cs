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
/// Represents a function call that can be used in A2UI messages to specify actions to be performed by the client in response to user interactions or other events.
/// </summary>
[Description("Represents a function call that can be used in A2UI messages to specify actions to be performed by the client in response to user interactions or other events.")]
[DataContract]
[JsonConverter(typeof(JsonFunctionCallConverter))]
public record FunctionCall
{

    /// <summary>
    /// Gets the name of the function to call.
    /// </summary>
    [Description("The name of the function to call.")]
    [DataMember(Order = 1, Name = "call"), JsonPropertyOrder(1), JsonPropertyName("call")]
    public required string Call { get; init; }

    /// <summary>
    /// Gets the function's input arguments, if any.
    /// </summary>
    [Description("The function's input arguments, if any.")]
    [DataMember(Order = 2, Name = "args"), JsonPropertyOrder(2), JsonPropertyName("args")]
    public JsonNode? Args { get; init; }

    /// <summary>
    /// Gets the function's return type.
    /// </summary>
    [Description("The function's return type.")]
    [DataMember(Order = 3, Name = "returnType"), JsonPropertyOrder(3), JsonPropertyName("returnType")]
    public required FunctionReturnType ReturnType { get; init; } = FunctionReturnType.Boolean;

}

/// <summary>
/// Represents the based class of a function call with strongly-typed arguments.
/// </summary>
/// <typeparam name="TArgs">The type of the function's input arguments.</typeparam>
[Description("Represents the based class of a function call with strongly-typed arguments.")]
[DataContract]
public abstract record FunctionCall<TArgs> 
    : FunctionCall
    where TArgs : class
{

    /// <summary>
    /// Gets the function's input arguments.
    /// </summary>
    [JsonIgnore]
    public required TArgs Arguments
    {
        get
        {
            return Args is null ? null! : JsonSerializer.Deserialize(Args, ArgumentsTypeInfo)!;
        }
        init
        {
            Args = JsonSerializer.SerializeToNode(Arguments, ArgumentsTypeInfo);
        }
    }

    /// <summary>
    /// Gets the JSON type information for the arguments of type TArgs.
    /// </summary>
    [JsonIgnore]
    protected abstract JsonTypeInfo<TArgs> ArgumentsTypeInfo { get; }

}