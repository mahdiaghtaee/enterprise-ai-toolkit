using System.Security.Cryptography;
using System.Text;
using EnterpriseAI.Abstractions.Embeddings;

namespace EnterpriseAI.Core.Embeddings;

/// <summary>
/// Generates deterministic local embeddings for examples and tests without external services.
/// </summary>
public sealed class DeterministicEmbeddingGenerator : IEmbeddingGenerator
{
    private const int HashLength = 32;
    private readonly int _dimensions;

    public DeterministicEmbeddingGenerator(int dimensions = 8)
    {
        if (dimensions <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(dimensions),
                dimensions,
                "Embedding dimensions must be greater than zero.");
        }

        _dimensions = dimensions;
    }

    public Task<EmbeddingResponse> GenerateAsync(
        EmbeddingRequest request,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(request.Inputs);

        cancellationToken.ThrowIfCancellationRequested();

        var embeddings = new List<EmbeddingVector>(request.Inputs.Count);

        foreach (var input in request.Inputs)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (string.IsNullOrWhiteSpace(input.Id))
            {
                throw new ArgumentException("Embedding input IDs must be non-empty.", nameof(request));
            }

            if (input.Text is null)
            {
                throw new ArgumentException("Embedding input text must not be null.", nameof(request));
            }

            var hash = SHA256.HashData(Encoding.UTF8.GetBytes(input.Text));
            var values = new float[_dimensions];

            for (var index = 0; index < values.Length; index++)
            {
                var byteValue = hash[index % HashLength];
                values[index] = (byteValue / 127.5f) - 1f;
            }

            embeddings.Add(new EmbeddingVector(input.Id, values));
        }

        return Task.FromResult(
            new EmbeddingResponse(
                embeddings,
                _dimensions,
                request.Model ?? "deterministic-sha256"));
    }
}
