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

namespace A2UI.UnitTests.Cases.Core;

public class ClientDataModelTests
{
    [Fact]
    public void Serialize_And_Deserialize_ClientDataModel_Should_Work()
    {
        //arrange
        var toSerialize = ClientDataModelFactory.Create();
        //act
        var json = JsonSerializer.Serialize(toSerialize, JsonSerializationContext.Default.ClientDataModel);
        var deserialized = JsonSerializer.Deserialize(json, JsonSerializationContext.Default.ClientDataModel);
        //assert
        json.Should().NotBeNullOrWhiteSpace();
        deserialized.Should().BeJsonEquivalentTo(toSerialize);
    }
}