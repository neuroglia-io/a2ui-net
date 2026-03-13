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
/// Represents an error that occurred during client-side validation.
/// </summary>
[Description("Represents an error that occurred during client-side validation.")]
[DataContract]
public sealed record ClientSideValidationError
    : ClientSideError
{

    /// <inheritdoc/>
    public override string Code { get; init; } = A2UISpecificationDefaults.ErrorCodes.ValidationFailed;

    /// <summary>
    /// Gets the JSON Pointer that references the specific part of the data model that failed validation.
    /// </summary>
    [Description("The JSON Pointer that references the specific part of the data model that failed validation.")]
    [DataMember(Order = 4, Name = "path"), JsonPropertyOrder(4), JsonPropertyName("path")]
    public required JsonPointer Path { get; init; }

}
