#pragma warning disable IDE0130 // Namespace does not match folder structure
using AwesomeAssertions.Primitives;

namespace A2UI.UnitTests;

internal static class ObjectAssertionsExtensions
{
    internal static void BeJsonEquivalentTo<T>(this ObjectAssertions should, T expected)
    {
        should.BeEquivalentTo(expected, opts => opts
            .Using<JsonNode>(ctx =>
                ctx.Subject?.ToJsonString().Should().Be(ctx.Expectation?.ToJsonString()))
                .WhenTypeIs<JsonNode>()
            .Using<JsonObject>(ctx =>
                ctx.Subject?.ToJsonString().Should().Be(ctx.Expectation?.ToJsonString()))
                .WhenTypeIs<JsonObject>());
    }
}
