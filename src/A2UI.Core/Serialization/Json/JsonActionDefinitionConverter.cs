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
/// Represents a JSON converter for <see cref="ActionDefinition"/> types.
/// </summary>
public class JsonActionDefinitionConverter
    : JsonConverter<ActionDefinition>
{

    const string EventPropertyName = "event";
    const string FunctionCallPropertyName = "functionCall";

    /// <inheritdoc/>
    public override ActionDefinition? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;
        var hasEvent = root.TryGetProperty(EventPropertyName, out _);
        var hasFunctionCall = root.TryGetProperty(FunctionCallPropertyName, out _);
        if (hasEvent && hasFunctionCall) throw new JsonException($"An {nameof(ActionDefinition)} cannot define both '{EventPropertyName}' and '{FunctionCallPropertyName}' properties.");
        if (!hasEvent && !hasFunctionCall) throw new JsonException($"An {nameof(ActionDefinition)} must contain either '{EventPropertyName}' or '{FunctionCallPropertyName}'.");
        var raw = root.GetRawText();
        if (hasEvent) return JsonSerializer.Deserialize(raw, JsonSerializationContext.Default.EventAction);
        else return JsonSerializer.Deserialize(raw, JsonSerializationContext.Default.FunctionCallAction);
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, ActionDefinition value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case EventAction eventAction:
                JsonSerializer.Serialize(writer, eventAction, JsonSerializationContext.Default.EventAction);
                break;
            case FunctionCallAction functionCallAction:
                JsonSerializer.Serialize(writer, functionCallAction, JsonSerializationContext.Default.FunctionCallAction);
                break;
            default:
                throw new JsonException($"Unsupported ActionDefinition type: {value.GetType().Name}");
        }
    }

}