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

using A2UI.Messages;

namespace A2UI.UnitTests.Services;

internal static class MessageFactory
{
    internal static DeleteSurfaceMessage CreateDeleteSurfaceMessage() => new()
    {
        Payload = new()
        {
            SurfaceId = Guid.NewGuid().ToString("N")
        }
    };

    internal static CreateSurfaceMessage CreateSurfaceMessage() => new()
    {
        Payload = new()
        {
            SurfaceId = Guid.NewGuid().ToString("N"),
            CatalogId = Guid.NewGuid().ToString("N"),
            Theme = ThemeFactory.Create(),
            SendDataModel = true
        }
    };

    internal static UpdateComponentsMessage CreateUpdateComponentsMessage() => new()
    {
        Payload = new()
        {
            SurfaceId = Guid.NewGuid().ToString("N"),
            Components =
            [
                ComponentFactory.CreateButton(),
                    ComponentFactory.CreateText(),
                    ComponentFactory.CreateImage()
            ]
        }
    };

    internal static UpdateDataModelMessage CreateUpdateDataModelMessage() => new()
    {
        Payload = new()
        {
            SurfaceId = Guid.NewGuid().ToString("N"),
            Path = JsonPointer.Create("/fake-path"),
            Value = JsonValue.Create("updated value")
        }
    };
}
