namespace EnterpriseAI.Abstractions.Embeddings;

/// <summary>
/// Represents a provider-independent embedding request for one or more inputs.
/// </summary>
/// <param name="Inputs">Inputs to embed in caller-defined order.</param>
/// <param name="Model">Optional provider model identifier.</param>
public sealed record EmbeddingRequest(
    IReadOnlyList<EmbeddingInput> Inputs,
    string? Model = null);
