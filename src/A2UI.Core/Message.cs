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
/// Represents an A2UI message. Messages are used to communicate between components and the application. They can be used to trigger actions, update state, or notify about events. Messages are immutable and can be created using record types for convenience.
/// </summary>
[Description("Represents an A2UI message. Messages are used to communicate between components and the application. They can be used to trigger actions, update state, or notify about events. Messages are immutable and can be created using record types for convenience.")]
[DataContract]
public abstract record Message
{

    /// <summary>
    /// Gets or sets the version of the A2UI specification that this message conforms to. This can be used for compatibility checks and to ensure that the message is processed correctly by components that may support different versions of the A2UI specification.
    /// </summary>
    [Description("The version of the A2UI specification that this message conforms to.")]
    [DataMember(Order = 1, Name = "version"), JsonPropertyOrder(1), JsonPropertyName("version")]
    public string Version { get; set; } = A2UISpecificationDefaults.Version;

}

/// <summary>
/// Represents an A2UI message. Messages are used to communicate between components and the application. They can be used to trigger actions, update state, or notify about events. Messages are immutable and can be created using record types for convenience.
/// </summary>
/// <typeparam name="TPayload">The type of the payload contained in the message. The payload contains the data associated with the message and can be used by components to perform actions or update state based on the information contained within it.</typeparam>
public abstract record Message<TPayload> 
    : Message
    where TPayload : notnull
{

    /// <summary>
    /// Gets or sets the payload of the message. The payload contains the data associated with the message and can be used by components to perform actions or update state based on the information contained within it.
    /// </summary>
    [Description("The payload of the message.")]
    [DataMember(Order = 2, Name = "payload"), JsonPropertyOrder(2), JsonPropertyName("payload")]
    public required TPayload Payload { get; init; }

}