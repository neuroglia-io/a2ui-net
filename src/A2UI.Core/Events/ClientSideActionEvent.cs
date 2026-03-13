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

namespace A2UI.Events;

/// <summary>
/// Represents a client-side event that reports a user-initiated action from the UI.
/// </summary>
[Description("Represents a client-side event that reports a user-initiated action from the UI.")]
[DataContract]
public sealed record ClientSideActionEvent
    : ClientSideEvent
{

    /// <summary>
    /// Gets the action that was performed by the user.
    /// </summary>
    [Description("The action that was performed by the user.")]
    [Required]
    [DataMember(Order = 2, Name = "action"), JsonPropertyOrder(2), JsonPropertyName("action")]
    public required ClientSideAction Action { get; init; }

}
