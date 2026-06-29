namespace EnterpriseAI.Abstractions.Chat;

public sealed record ChatRequest(IReadOnlyList<ChatMessage> Messages, string? Model = null);
