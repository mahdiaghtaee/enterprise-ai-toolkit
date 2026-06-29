namespace EnterpriseAI.Abstractions.Chat;

public sealed record ChatResponse(ChatMessage Message, string? Model = null);
