namespace EnterpriseAI.Abstractions.Embeddings;

/// <summary>
/// Defines a provider-independent contract for generating text embeddings.
/// </summary>
public interface IEmbeddingGenerator
{
    /// <summary>
    /// Generates embeddings for all request inputs while preserving input identifiers.
    /// </summary>
    /// <param name="request">Embedding request.</param>
    /// <param name="cancellationToken">Cancellation token for the operation.</param>
    /// <returns>Generated embeddings in request order.</returns>
    Task<EmbeddingResponse> GenerateAsync(
        EmbeddingRequest request,
        CancellationToken cancellationToken = default);
}
