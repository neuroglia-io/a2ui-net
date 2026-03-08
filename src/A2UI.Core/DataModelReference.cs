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
/// Represents a reference to a value in the data model.
/// </summary>
[Description("Represents a reference to a value in the data model.")]
[DataContract]
public sealed record DataModelReference
{

    /// <summary>
    /// Gets the path to the value in the data model.
    /// </summary>
    [Description("The path to the value in the data model.")]
    [Required]
    [DataMember(Order = 1, Name = "path"), JsonPropertyOrder(1), JsonPropertyName("path")]
    public required JsonPointer Path { get; init; }

    /// <inheritdoc/>
    public override string ToString() => Path.ToString();

}
