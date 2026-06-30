namespace EnterpriseAI.Abstractions;

/// <summary>
/// Represents a provider-agnostic chat client contract.
/// </summary>
public interface IChatClient
{
    /// <summary>
    /// Sends a prompt and returns a response.
    /// </summary>
    Task<string> CompleteAsync(string prompt, CancellationToken cancellationToken = default);
}
