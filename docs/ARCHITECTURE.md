# Enterprise AI Toolkit Architecture

## Goal

Enterprise AI Toolkit is designed to provide clean .NET abstractions for enterprise AI systems without coupling the application to a single model provider, vector database, or document-processing pipeline.

The architecture favors explicit contracts, small modules, and testable boundaries.

---

## Core Layers

### 1. Abstractions

The abstractions layer defines provider-independent contracts and models.

Examples:

- Chat clients
- Embedding generators
- Vector stores
- Document chunkers
- Retrieval services
- RAG pipelines

This layer should remain lightweight and free from concrete vendor dependencies.

### 2. Core

The core layer contains reusable orchestration logic that depends on abstractions, not providers.

Examples:

- Request validation
- Pipeline orchestration
- Retry policies
- Common result models
- Shared domain services

### 3. Providers

Provider packages implement the abstractions for specific services.

Examples:

- OpenAI
- Azure OpenAI
- Ollama
- Qdrant
- PostgreSQL vector extensions

Provider packages should be replaceable without changing application logic.

### 4. RAG

The RAG layer connects retrieval, ranking, prompt construction, and answer generation.

A typical flow:

```text
User Question
  -> Query Embedding
  -> Vector Search
  -> Context Selection
  -> Prompt Construction
  -> LLM Answer
  -> Source Attribution
```

### 5. Documents

The document layer handles ingestion and preparation for retrieval.

A typical flow:

```text
Document Upload
  -> Text Extraction
  -> Chunking
  -> Metadata Assignment
  -> Embedding Generation
  -> Vector Storage
```

---

## Design Rules

- Application code should depend on abstractions, not provider SDKs.
- Tests should be able to run without external AI providers.
- Provider implementations should be replaceable.
- RAG responses should support source attribution.
- Samples should remain small and runnable.
- Production features should be introduced behind clear interfaces.

---

## v0.1 Architecture Scope

The first milestone focuses only on:

- Core chat abstractions
- Request and response models
- Testable provider contracts
- A minimal runnable sample
- CI validation for build and tests

The goal is to keep the first version small, understandable, and maintainable.

---

## Portfolio Message

This architecture demonstrates enterprise-ready AI backend thinking: separation of concerns, provider independence, testability, and a clear path from demo to production.
