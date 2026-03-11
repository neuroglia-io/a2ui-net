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
/// Represents a client-side function call that can be executed by an interaction handler, allowing the client to perform local operations such as updating the UI, manipulating data, or executing custom logic without needing to communicate with the server.
/// </summary>
[Description("Represents a client-side function call that can be executed by an interaction handler, allowing the client to perform local operations such as updating the UI, manipulating data, or executing custom logic without needing to communicate with the server.")]
[DataContract]
public sealed record FunctionCallAction
    : ActionDefinition
{

    /// <summary>
    /// Gets the client-side function call to execute.
    /// </summary>
    [Description("The client-side function call to execute.")]
    [DataMember(Order = 1, Name = "functionCall"), JsonPropertyOrder(1), JsonPropertyName("functionCall")]
    public required FunctionCall FunctionCall { get; init; }

}