namespace EnterpriseAI.Abstractions.Chat;

/// <summary>
/// Represents the role of a message in a chat conversation.
/// </summary>
public enum ChatRole
{
    /// <summary>
    /// System-level instruction or context.
    /// </summary>
    System,

    /// <summary>
    /// User-provided message.
    /// </summary>
    User,

    /// <summary>
    /// Assistant-generated message.
    /// </summary>
    Assistant,

    /// <summary>
    /// Tool-generated message.
    /// </summary>
    Tool
}
