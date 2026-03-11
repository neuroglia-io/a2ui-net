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
/// Represents attributes to enhance accessibility when using assistive technologies like screen readers.
/// </summary>
[Description("Represents attributes to enhance accessibility when using assistive technologies like screen readers.")]
[DataContract]
public sealed record AccessibilityAttributes
{

    /// <summary>
    /// Gets a short string, typically 1 to 3 words, used by assistive technologies to convey the purpose or intent of an element.
    /// </summary>
    [Description("A short string, typically 1 to 3 words, used by assistive technologies to convey the purpose or intent of an element.")]
    [DataMember(Order = 1, Name = "label"), JsonPropertyOrder(1), JsonPropertyName("label")]
    [JsonConverter(typeof(JsonOneOfConverter<DataBinding, FunctionCall, string>))]
    public OneOf<DataBinding, FunctionCall, string>? Label { get; init; }

    /// <summary>
    /// Gets additional information provided by assistive technologies about an element such as instructions, format requirements, or results of an action.
    /// </summary>
    [Description("Additional information provided by assistive technologies about an element such as instructions, format requirements, or results of an action.")]
    [DataMember(Order = 2, Name = "description"), JsonPropertyOrder(2), JsonPropertyName("description")]
    [JsonConverter(typeof(JsonOneOfConverter<DataBinding, FunctionCall, string>))]
    public OneOf<DataBinding, FunctionCall, string>? Description { get; init; }

}
