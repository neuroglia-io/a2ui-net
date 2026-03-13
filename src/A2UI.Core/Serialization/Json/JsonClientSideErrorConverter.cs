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

namespace A2UI.Serialization.Json;

/// <summary>
/// Represents a JSON converter for <see cref="ClientSideError"/>s.
/// </summary>
public sealed class JsonClientSideErrorConverter
    : JsonConverter<ClientSideError>
{

    /// <inheritdoc/>
    public override ClientSideError? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var node = JsonNode.Parse(ref reader)?.AsObject() ?? throw new JsonException("Expected JSON object.");
        if (!node.TryGetPropertyValue("code", out var codeNode) || codeNode is null) throw new JsonException("Missing 'code' property.");
        var code = codeNode.GetValue<string>();
        var json = node.ToJsonString();
        return code switch
        {
            A2UISpecificationDefaults.ErrorCodes.ValidationFailed => JsonSerializer.Deserialize(json, JsonSerializationContext.Default.ClientSideValidationError),
            _ => JsonSerializer.Deserialize(json, JsonSerializationContext.Default.ClientSideGenericError),
        };
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, ClientSideError value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case ClientSideGenericError genericError:
                JsonSerializer.Serialize(writer, genericError, JsonSerializationContext.Default.ClientSideGenericError);
                break;
            case ClientSideValidationError validationError:
                JsonSerializer.Serialize(writer, validationError, JsonSerializationContext.Default.ClientSideValidationError);
                break;
            default:
                throw new NotSupportedException($"Unsupported ClientSideError type: {value.GetType().FullName}");
        }
    }

}
