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
/// Represents an event action that can be triggered by an interaction handler, allowing the client to communicate with the server and perform actions such as form submission, data retrieval, or other server-side operations.
/// </summary>
[Description("Represents an event action that can be triggered by an interaction handler, allowing the client to communicate with the server and perform actions such as form submission, data retrieval, or other server-side operations.")]
[DataContract]
public sealed record EventAction
    : ActionDefinition
{

    /// <summary>
    /// Gets the server event to trigger.
    /// </summary>
    [Description("The server event to trigger.")]
    [DataMember(Order = 1, Name = "event"), JsonPropertyOrder(1), JsonPropertyName("event")]
    public required ServerEvent Event { get; init; }

}
