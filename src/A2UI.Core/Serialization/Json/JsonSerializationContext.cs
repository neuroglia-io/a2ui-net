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

using A2UI.Components;
using A2UI.Events;
using A2UI.Messages;

namespace A2UI.Serialization.Json;

/// <summary>
/// Represents the JSON serialization context for A2UI core types
/// </summary>
[JsonSourceGenerationOptions(GenerationMode = JsonSourceGenerationMode.Metadata, PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, WriteIndented = false, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, AllowOutOfOrderMetadataProperties = true)]
[JsonSerializable(typeof(AccessibilityAttributes))]
[JsonSerializable(typeof(ActionDefinition))]
[JsonSerializable(typeof(Alignment))]
[JsonSerializable(typeof(AndFunctionArgs))]
[JsonSerializable(typeof(AndFunctionCall))]
[JsonSerializable(typeof(CheckRule))]
[JsonSerializable(typeof(ChoicePickerOption))]
[JsonSerializable(typeof(ClientDataModel))]
[JsonSerializable(typeof(ClientSideAction))]
[JsonSerializable(typeof(ClientSideActionEvent))]
[JsonSerializable(typeof(ClientSideEvent))]
[JsonSerializable(typeof(ClientSideErrorEvent))]
[JsonSerializable(typeof(ClientSideError))]
[JsonSerializable(typeof(ClientSideGenericError))]
[JsonSerializable(typeof(ClientSideValidationError))]
[JsonSerializable(typeof(Component))]
[JsonSerializable(typeof(ComponentTemplate))]
[JsonSerializable(typeof(CreateSurfaceMessage))]
[JsonSerializable(typeof(CreateSurfaceMessagePayload))]
[JsonSerializable(typeof(DataBinding))]
[JsonSerializable(typeof(DeleteSurfaceMessage))]
[JsonSerializable(typeof(DeleteSurfaceMessagePayload))]
[JsonSerializable(typeof(EmailFunctionArgs))]
[JsonSerializable(typeof(EmailFunctionCall))]
[JsonSerializable(typeof(EventAction))]
[JsonSerializable(typeof(FormatCurrencyFunctionArgs))]
[JsonSerializable(typeof(FormatCurrencyFunctionCall))]
[JsonSerializable(typeof(FormatDateFunctionArgs))]
[JsonSerializable(typeof(FormatDateFunctionCall))]
[JsonSerializable(typeof(FormatNumberFunctionArgs))]
[JsonSerializable(typeof(FormatNumberFunctionCall))]
[JsonSerializable(typeof(FormatStringFunctionArgs))]
[JsonSerializable(typeof(FormatStringFunctionCall))]
[JsonSerializable(typeof(FunctionCall))]
[JsonSerializable(typeof(FunctionCallAction))]
[JsonSerializable(typeof(IconName))]
[JsonSerializable(typeof(Justify))]
[JsonSerializable(typeof(LengthFunctionArgs))]
[JsonSerializable(typeof(LengthFunctionCall))]
[JsonSerializable(typeof(NotFunctionArgs))]
[JsonSerializable(typeof(NotFunctionCall))]
[JsonSerializable(typeof(NumericFunctionArgs))]
[JsonSerializable(typeof(NumericFunctionCall))]
[JsonSerializable(typeof(OneOf<DataBinding, string>))]
[JsonSerializable(typeof(OpenUrlFunctionArgs))]
[JsonSerializable(typeof(OpenUrlFunctionCall))]
[JsonSerializable(typeof(OrFunctionArgs))]
[JsonSerializable(typeof(OrFunctionCall))]
[JsonSerializable(typeof(PluralizeFunctionArgs))]
[JsonSerializable(typeof(PluralizeFunctionCall))]
[JsonSerializable(typeof(RegexFunctionArgs))]
[JsonSerializable(typeof(RegexFunctionCall))]
[JsonSerializable(typeof(RequiredFunctionArgs))]
[JsonSerializable(typeof(RequiredFunctionCall))]
[JsonSerializable(typeof(ServerEvent))]
[JsonSerializable(typeof(string[]))]
[JsonSerializable(typeof(Tab))]
[JsonSerializable(typeof(UpdateComponentsMessage))]
[JsonSerializable(typeof(UpdateComponentsMessagePayload))]
[JsonSerializable(typeof(UpdateDataModelMessage))]
[JsonSerializable(typeof(UpdateDataModelMessagePayload))]
[JsonSerializable(typeof(Uri))]
public partial class JsonSerializationContext
    : JsonSerializerContext
{


}
