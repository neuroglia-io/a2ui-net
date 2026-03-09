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
/// Represents a message that updates the data model with a specified payload.
/// </summary>
[Description("Represents a message that updates the data model with a specified payload.")]
[DataContract]
public sealed record UpdateDataModelMessage
    : Message
{

    /// <summary>
    /// Gets the message's payload, which contains the details of the data model to be updated.
    /// </summary>
    [Description("The message's payload, which contains the details of the data model to be updated.")]
    [DataMember(Order = 2, Name = "updateDataModel"), JsonPropertyOrder(2), JsonPropertyName("updateDataModel")]
    public required UpdateDataModelMessagePayload UpdateDataModel { get; init; }

}
