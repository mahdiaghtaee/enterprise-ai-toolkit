using System.Collections.Generic;
using EnterpriseAI.Abstractions.Chat;
using EnterpriseAI.Core.Chat;
using Xunit;

namespace EnterpriseAI.Tests;

public sealed class ChatAbstractionTests
{
    [Fact]
    public void Chat_request_preserves_messages_and_model()
    {
        var request = new ChatRequest(
            new List<ChatMessage>
            {
                new(ChatRole.User, "Summarize this document.")
            },
            "test-model");

        Assert.Single(request.Messages);
        Assert.Equal(ChatRole.User, request.Messages[0].Role);
        Assert.Equal("Summarize this document.", request.Messages[0].Content);
        Assert.Equal("test-model", request.Model);
    }

    [Fact]
    public void In_memory_chat_provider_returns_echo_response_without_external_provider()
    {
        var provider = new InMemoryChatProvider();
        var request = new ChatRequest(
            new List<ChatMessage>
            {
                new(ChatRole.User, "Hello")
            },
            "test-model");

        var response = provider.CreateReply(request);

        Assert.Equal(ChatRole.Assistant, response.Message.Role);
        Assert.Equal("Echo: Hello", response.Message.Content);
        Assert.Equal("test-model", response.Model);
    }
}
