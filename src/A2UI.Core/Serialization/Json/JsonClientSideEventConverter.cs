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

using A2UI.Events;

namespace A2UI.Serialization.Json;

/// <summary>
/// Represents a JSON converter for <see cref="ClientSideEvent"/>s.
/// </summary>
public sealed class JsonClientSideEventConverter
    : JsonConverter<ClientSideEvent>
{

    const string ActionPropertyName = "action";
    const string ErrorPropertyName = "error";

    /// <inheritdoc/>
    public override ClientSideEvent? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;
        var hasAction = root.TryGetProperty(ActionPropertyName, out _);
        var hasError = root.TryGetProperty(ErrorPropertyName, out _);
        if (hasAction && hasError) throw new JsonException($"An {nameof(ActionDefinition)} cannot define both '{ActionPropertyName}' and '{ErrorPropertyName}' properties.");
        if (!hasAction && !hasError) throw new JsonException($"An {nameof(ActionDefinition)} must contain either '{ActionPropertyName}' or '{ErrorPropertyName}'.");
        var raw = root.GetRawText();
        if (hasAction) return JsonSerializer.Deserialize(raw, JsonSerializationContext.Default.ClientSideActionEvent);
        else return JsonSerializer.Deserialize(raw, JsonSerializationContext.Default.ClientSideErrorEvent);
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, ClientSideEvent value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case ClientSideActionEvent actionEvent:
                JsonSerializer.Serialize(writer, actionEvent, JsonSerializationContext.Default.ClientSideActionEvent);
                break;
            case ClientSideErrorEvent errorEvent:
                JsonSerializer.Serialize(writer, errorEvent, JsonSerializationContext.Default.ClientSideErrorEvent);
                break;
            default:
                throw new NotSupportedException($"Unsupported ClientSideEvent type: {value.GetType().FullName}");
        }
    }

}