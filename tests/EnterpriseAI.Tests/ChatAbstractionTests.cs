using EnterpriseAI.Abstractions;
using EnterpriseAI.Core;
using Xunit;

namespace EnterpriseAI.Tests;

public sealed class ChatAbstractionTests
{
    [Fact]
    public void Chat_request_preserves_prompt()
    {
        var request = new ChatRequest("Summarize this document.");

        Assert.Equal("Summarize this document.", request.Prompt);
    }

    [Fact]
    public async Task Chat_client_contract_can_be_implemented_without_external_provider()
    {
        IChatClient client = new FakeChatClient("Test response");

        var response = await client.CompleteAsync("Hello");

        Assert.Equal("Test response", response);
    }

    private sealed class FakeChatClient : IChatClient
    {
        private readonly string _response;

        public FakeChatClient(string response)
        {
            _response = response;
        }

        public Task<string> CompleteAsync(string prompt, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(_response);
        }
    }
}
