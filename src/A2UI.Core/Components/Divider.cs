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

namespace A2UI.Components;

/// <summary>
/// Represents a component used to render a divider line.
/// </summary>
[Description("Represents a component used to render a divider line.")]
[DataContract]
public sealed record Divider
    : Component
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore]
    public override string Type => ComponentType.Divider;

    /// <summary>
    /// Gets the axis along which the divider is rendered, if any.
    /// </summary>
    [Description("The axis along which the divider is rendered, if any.")]
    [DataMember(Order = 4, Name = "axis"), JsonPropertyOrder(4), JsonPropertyName("axis")]
    public Direction? Axis { get; init; }

}