# Console Sample

The console sample demonstrates the current chat abstractions using the in-memory chat provider.

It is intentionally local and does not require API keys, external AI providers, or vector databases.

## Commands

```bash
dotnet restore EnterpriseAI.sln
dotnet build EnterpriseAI.sln --configuration Release --no-restore
dotnet test EnterpriseAI.sln --configuration Release --no-build
dotnet run --project examples/ConsoleSample/ConsoleSample.csproj
```

## What It Demonstrates

- Creating a provider-agnostic chat request
- Using system and user chat messages
- Calling the in-memory chat provider
- Returning a provider-independent chat response

This keeps the first sample simple while the toolkit is still in the foundation stage.
