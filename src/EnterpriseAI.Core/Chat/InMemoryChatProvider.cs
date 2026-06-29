using EnterpriseAI.Abstractions.Chat;

namespace EnterpriseAI.Core.Chat;

public sealed class InMemoryChatProvider
{
    public ChatResponse CreateReply(ChatRequest request)
    {
        var lastUserMessage = request.Messages.LastOrDefault(message => message.Role == ChatRole.User);
        var replyText = lastUserMessage is null
            ? "No user message was provided."
            : $"Echo: {lastUserMessage.Content}";

        return new ChatResponse(new ChatMessage(ChatRole.Assistant, replyText), request.Model);
    }
}
