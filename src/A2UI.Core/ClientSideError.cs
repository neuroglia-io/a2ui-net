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
/// Represents an error that occurred on the client side.
/// </summary>
[Description("Represents an error that occurred on the client side.")]
[DataContract]
[JsonConverter(typeof(JsonClientSideErrorConverter))]
public abstract record ClientSideError
{

    /// <summary>
    /// Gets the error code.
    /// </summary>
    [Description("The error code.")]
    [Required, StringLength(int.MaxValue, MinimumLength = 1)]
    [DataMember(Order = 1, Name = "code"), JsonPropertyOrder(1), JsonPropertyName("code")]
    public abstract string Code { get; init; }

    /// <summary>
    /// Gets the error message.
    /// </summary>
    [Description("The error message.")]
    [Required, StringLength(int.MaxValue, MinimumLength = 1)]
    [DataMember(Order = 2, Name = "message"), JsonPropertyOrder(2), JsonPropertyName("message")]
    public required string Message { get; init; }

    /// <summary>
    /// Gets the unique identifier of the surface where the error occurred.
    /// </summary>
    [Description("The unique identifier of the surface where the error occurred.")]
    [Required, StringLength(int.MaxValue, MinimumLength = 1)]
    [DataMember(Order = 3, Name = "surfaceId"), JsonPropertyOrder(3), JsonPropertyName("surfaceId")]
    public required string SurfaceId { get; init; }

}
