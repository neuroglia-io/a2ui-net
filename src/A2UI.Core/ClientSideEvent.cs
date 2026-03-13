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
/// Represents a client-side event triggered from the UI.
/// </summary>
[Description("Represents a client-side event triggered from the UI.")]
[DataContract]
[JsonConverter(typeof(JsonClientSideEventConverter))]
public abstract record ClientSideEvent
{

    /// <summary>
    /// Gets or sets the version of the A2UI specification that this message conforms to. This can be used for compatibility checks and to ensure that the message is processed correctly by components that may support different versions of the A2UI specification.
    /// </summary>
    [Description("The version of the A2UI specification that this message conforms to.")]
    [DataMember(Order = 1, Name = "version"), JsonPropertyOrder(1), JsonPropertyName("version")]
    public string Version { get; init; } = A2UISpecificationDefaults.Version;

}
