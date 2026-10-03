namespace EnterpriseAI.Abstractions.Embeddings;

/// <summary>
/// Represents an embedding vector correlated to an input identifier.
/// </summary>
/// <param name="Id">Identifier copied from the corresponding request input.</param>
/// <param name="Values">Generated vector values.</param>
public sealed record EmbeddingVector(string Id, IReadOnlyList<float> Values);

/// <summary>
/// Represents a provider-independent embedding response.
/// </summary>
/// <param name="Embeddings">Generated embeddings in request order.</param>
/// <param name="Dimensions">Vector dimension used by every returned embedding.</param>
/// <param name="Model">Provider model identifier when one is available.</param>
public sealed record EmbeddingResponse(
    IReadOnlyList<EmbeddingVector> Embeddings,
    int Dimensions,
    string? Model = null);
