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

namespace A2UI.Functions;

/// <summary>
/// Represents the input arguments for an <see cref="OpenUrlFunctionCall" />.
/// </summary>
[Description("Represents the input arguments for an OpenUrlFunctionCall.")]
[DataContract]
public sealed record OpenUrlFunctionArgs
{

    /// <summary>
    /// Gets the URL to open.
    /// </summary>
    [Description("The URL to open.")]
    [DataMember(Order = 1, Name = "url"), JsonPropertyOrder(1), JsonPropertyName("url")]
    public required Uri Url { get; init; }

}
