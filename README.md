# Enterprise AI Toolkit

Modular .NET toolkit for building enterprise AI applications with RAG pipelines, vector search, provider integrations, and production-ready architecture patterns.

## Purpose

Enterprise AI Toolkit is designed as a practical foundation for production-minded AI applications in .NET. The goal is to provide clean abstractions, small composable modules, and runnable examples for common enterprise AI scenarios.

## Target Use Cases

- Document question answering with RAG
- Enterprise search over internal knowledge bases
- Provider-agnostic LLM integrations
- Embedding and vector search workflows
- AI assistants connected to business systems
- Document ingestion and semantic retrieval

## Planned Structure

```text
src/
  EnterpriseAI.Abstractions/
  EnterpriseAI.Core/
  EnterpriseAI.Providers.OpenAI/
  EnterpriseAI.Providers.Ollama/
  EnterpriseAI.VectorStores.Qdrant/
  EnterpriseAI.RAG/
  EnterpriseAI.Documents/
  EnterpriseAI.WebApi/

tests/
examples/
docs/
```

## Roadmap

### v0.1 - Foundations
- Define core abstractions
- Add LLM provider contracts
- Add embedding provider contracts
- Add minimal console sample
- Add initial documentation

### v0.2 - RAG Basics
- Add document chunking contracts
- Add embedding pipeline
- Add vector store abstraction
- Add simple retrieval sample

### v0.3 - Documents
- Add document ingestion abstractions
- Add PDF and text ingestion examples
- Add metadata model
- Add document search sample

## Engineering Principles

- Provider-agnostic design
- Clean and testable abstractions
- Small modules over large frameworks
- Practical samples over theoretical examples
- Production-oriented structure
- Clear documentation for each capability

## Current Status

Early foundation stage. The first development milestone is `v0.1`, focused on project structure, abstractions, and one runnable sample.

## License

MIT
