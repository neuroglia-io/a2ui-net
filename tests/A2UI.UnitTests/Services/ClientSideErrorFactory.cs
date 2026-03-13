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

namespace A2UI.UnitTests.Services;

internal static class ClientSideErrorFactory
{
    internal static ClientSideGenericError CreateGenericError() => new()
    {
        Code = "TestError",
        Message = "This is a test error.",
        SurfaceId = "TestSurface",
    };

    internal static ClientSideValidationError CreateValidationError() => new()
    {
        Message = "This is a validation error.",
        SurfaceId = "TestSurface",
        Path = JsonPointer.Parse("/data/attributes/name")
    };
}