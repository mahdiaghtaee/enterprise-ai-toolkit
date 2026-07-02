using EnterpriseAI.Abstractions.Chat;
using EnterpriseAI.Core.Chat;

var provider = new InMemoryChatProvider();

var request = new ChatRequest(
    new List<ChatMessage>
    {
        new(ChatRole.System, "You are a helpful enterprise AI assistant."),
        new(ChatRole.User, "Summarize the purpose of this toolkit.")
    },
    "in-memory-demo");

var response = provider.CreateReply(request);

Console.WriteLine("Enterprise AI Toolkit - Console Sample");
Console.WriteLine("--------------------------------------");
Console.WriteLine($"Model: {response.Model}");
Console.WriteLine($"Role: {response.Message.Role}");
Console.WriteLine($"Response: {response.Message.Content}");
