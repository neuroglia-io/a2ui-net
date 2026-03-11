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
/// Represents a server-side event that can be triggered by an interaction handler, allowing the client to communicate with the server and perform actions such as form submission, data retrieval, or other server-side operations.
/// </summary>
[Description("Represents a server-side event that can be triggered by an interaction handler, allowing the client to communicate with the server and perform actions such as form submission, data retrieval, or other server-side operations.")]
[DataContract]
public sealed record ServerEvent
{

    /// <summary>
    /// Gets the name of the action to be dispatched to the server.
    /// </summary>
    [Description("The name of the action to be dispatched to the server.")]
    [Required, StringLength(int.MaxValue, MinimumLength = 1)]
    [DataMember(Order = 1, Name = "name"), JsonPropertyOrder(1), JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Gets an object containing the key-value pairs for the action context.
    /// </summary>
    [Description("An object containing the key-value pairs for the action context.")]
    [DataMember(Order = 2, Name = "context"), JsonPropertyOrder(2), JsonPropertyName("context")]
    public JsonObject? Context { get; init; }

}
