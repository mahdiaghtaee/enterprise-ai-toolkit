namespace EnterpriseAI.Abstractions.Embeddings;

/// <summary>
/// Represents one text input to embed and its caller-provided stable identifier.
/// </summary>
/// <param name="Id">Identifier used to correlate the generated vector with the input.</param>
/// <param name="Text">Text content to embed.</param>
public sealed record EmbeddingInput(string Id, string Text);
