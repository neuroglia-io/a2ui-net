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
/// Represents a JSON converter for <see cref="FunctionCall"/>s.
/// </summary>
public sealed class JsonFunctionCallConverter
    : JsonConverter<FunctionCall>
{

    /// <inheritdoc/>
    public override FunctionCall? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var node = JsonNode.Parse(ref reader)?.AsObject() ?? throw new JsonException("Expected JSON object.");
        if (!node.TryGetPropertyValue("call", out var callNode) || callNode is null) throw new JsonException("Missing 'call' property.");
        var call = callNode.GetValue<string>();
        var json = node.ToJsonString();
        return call switch
        {
            RequiredFunctionCall.FunctionName => JsonSerializer.Deserialize(json, JsonSerializationContext.Default.RequiredFunctionCall),
            RegexFunctionCall.FunctionName => JsonSerializer.Deserialize(json, JsonSerializationContext.Default.RegexFunctionCall),
            LengthFunctionCall.FunctionName => JsonSerializer.Deserialize(json, JsonSerializationContext.Default.LengthFunctionCall),
            NumericFunctionCall.FunctionName => JsonSerializer.Deserialize(json, JsonSerializationContext.Default.NumericFunctionCall),
            EmailFunctionCall.FunctionName => JsonSerializer.Deserialize(json, JsonSerializationContext.Default.EmailFunctionCall),
            FormatStringFunctionCall.FunctionName => JsonSerializer.Deserialize(json, JsonSerializationContext.Default.FormatStringFunctionCall),
            FormatNumberFunctionCall.FunctionName => JsonSerializer.Deserialize(json, JsonSerializationContext.Default.FormatNumberFunctionCall),
            FormatCurrencyFunctionCall.FunctionName => JsonSerializer.Deserialize(json, JsonSerializationContext.Default.FormatCurrencyFunctionCall),
            FormatDateFunctionCall.FunctionName => JsonSerializer.Deserialize(json, JsonSerializationContext.Default.FormatDateFunctionCall),
            PluralizeFunctionCall.FunctionName => JsonSerializer.Deserialize(json, JsonSerializationContext.Default.PluralizeFunctionCall),
            OpenUrlFunctionCall.FunctionName => JsonSerializer.Deserialize(json, JsonSerializationContext.Default.OpenUrlFunctionCall),
            AndFunctionCall.FunctionName => JsonSerializer.Deserialize(json, JsonSerializationContext.Default.AndFunctionCall),
            OrFunctionCall.FunctionName => JsonSerializer.Deserialize(json, JsonSerializationContext.Default.OrFunctionCall),
            NotFunctionCall.FunctionName => JsonSerializer.Deserialize(json, JsonSerializationContext.Default.NotFunctionCall),
            _ => new FunctionCall
            {
                Call = call,
                Args = node["args"]?.DeepClone(),
                ReturnType = node["returnType"] is null ? FunctionReturnType.Boolean : JsonSerializer.Deserialize(node["returnType"]!, JsonSerializationContext.Default.FunctionReturnType)
            }
        };
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, FunctionCall value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteString("call", value.Call);
        if (value.Args is not null)
        {
            writer.WritePropertyName("args");
            value.Args.WriteTo(writer, options);
        }
        writer.WritePropertyName("returnType");
        JsonSerializer.Serialize(writer, value.ReturnType, JsonSerializationContext.Default.FunctionReturnType);
        writer.WriteEndObject();
    }

}