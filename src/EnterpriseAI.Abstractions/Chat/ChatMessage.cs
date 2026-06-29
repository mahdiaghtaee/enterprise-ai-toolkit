namespace EnterpriseAI.Abstractions.Chat;

public sealed record ChatMessage(ChatRole Role, string Content);
