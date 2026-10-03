using EnterpriseAI.Abstractions.Embeddings;
using EnterpriseAI.Core.Embeddings;
using Xunit;

namespace EnterpriseAI.Tests;

public sealed class EmbeddingAbstractionTests
{
    [Fact]
    public async Task Request_preserves_multiple_input_identifiers_and_dimensions()
    {
        var generator = new DeterministicEmbeddingGenerator(dimensions: 6);
        var request = new EmbeddingRequest(
            new[]
            {
                new EmbeddingInput("doc-1", "Enterprise search"),
                new EmbeddingInput("doc-2", "جستجوی سازمانی")
            },
            "test-embedding-model");

        var response = await generator.GenerateAsync(request);

        Assert.Equal(6, response.Dimensions);
        Assert.Equal("test-embedding-model", response.Model);
        Assert.Equal(new[] { "doc-1", "doc-2" }, response.Embeddings.Select(item => item.Id));
        Assert.All(response.Embeddings, item => Assert.Equal(6, item.Values.Count));
    }

    [Fact]
    public async Task Deterministic_provider_returns_same_vector_for_same_text()
    {
        var generator = new DeterministicEmbeddingGenerator();

        var first = await generator.GenerateAsync(
            new EmbeddingRequest(new[] { new EmbeddingInput("first", "same text") }));

        var second = await generator.GenerateAsync(
            new EmbeddingRequest(new[] { new EmbeddingInput("second", "same text") }));

        Assert.Equal(first.Embeddings[0].Values, second.Embeddings[0].Values);
        Assert.Equal("first", first.Embeddings[0].Id);
        Assert.Equal("second", second.Embeddings[0].Id);
    }

    [Fact]
    public async Task Deterministic_provider_distinguishes_different_text()
    {
        var generator = new DeterministicEmbeddingGenerator();

        var response = await generator.GenerateAsync(
            new EmbeddingRequest(
                new[]
                {
                    new EmbeddingInput("a", "first value"),
                    new EmbeddingInput("b", "second value")
                }));

        Assert.NotEqual(response.Embeddings[0].Values, response.Embeddings[1].Values);
    }

    [Fact]
    public async Task Deterministic_provider_honors_cancellation()
    {
        var generator = new DeterministicEmbeddingGenerator();
        using var source = new CancellationTokenSource();
        source.Cancel();

        await Assert.ThrowsAsync<OperationCanceledException>(
            () => generator.GenerateAsync(
                new EmbeddingRequest(new[] { new EmbeddingInput("a", "text") }),
                source.Token));
    }

    [Fact]
    public void Deterministic_provider_rejects_invalid_dimensions()
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () => new DeterministicEmbeddingGenerator(0));
    }
}
