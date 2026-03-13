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
/// Exposes default values about the A2UI specification.
/// </summary>
public static class A2UISpecificationDefaults
{

    /// <summary>
    /// Gets the default version of the A2UI specification that components and messages should conform to
    /// </summary>
    public const string Version = "v0.9";
    /// <summary>
    /// Gets the default content type for A2UI messages.
    /// </summary>
    public const string ContentType = "application/json+a2ui";
    /// <summary>
    /// Gets the default ID for the root component.
    /// </summary>
    public const string RootComponentId = "root";

    /// <summary>
    /// Exposes default catalogs that can be used by components and messages to reference standard definitions of components, surfaces, and other elements in the A2UI specification.
    /// </summary>
    public static class Catalogs
    {

        /// <summary>
        /// Gets the URL of the standard A2UI catalog.
        /// </summary>
        public const string Standard = "https://a2ui.org/specification/v0_9/basic_catalog.json";

    }

}