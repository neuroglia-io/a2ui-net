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

namespace A2UI.Messages;

/// <summary>
/// Represents a message that can be sent to delete an existing surface.
/// </summary>
[Description("Represents a message that can be sent to delete an existing surface.")]
[DataContract]
public sealed record DeleteSurfaceMessage
    : Message
{

    /// <summary>
    /// Gets the message's payload, which contains the details of the surface to delete.
    /// </summary>
    [Description("The message's payload, which contains the details of the surface to delete.")]
    [DataMember(Order = 2, Name = "deleteSurface"), JsonPropertyOrder(2), JsonPropertyName("deleteSurface")]
    public required DeleteSurfaceMessagePayload DeleteSurface { get; init; }

}
