# Enterprise AI Toolkit Architecture

## Goal

Enterprise AI Toolkit is designed to provide clean .NET abstractions for enterprise AI systems without coupling the application to a single model provider, vector database, or document-processing pipeline.

The architecture favors explicit contracts, small modules, and testable boundaries.

---

## Core Layers

### 1. Abstractions

The abstractions layer defines provider-independent contracts and models.

Implemented now:

- Chat request/response models and provider-neutral chat boundaries
- `IEmbeddingGenerator`
- `EmbeddingInput`, `EmbeddingRequest`, `EmbeddingVector`, and `EmbeddingResponse`

The embedding contract supports one or more inputs, preserves caller-defined identifiers, reports vector dimensions explicitly, and accepts cancellation without depending on a vendor SDK.

Planned boundaries such as vector stores, document chunkers, retrieval services, and RAG orchestration should be added only when justified by a runnable use case.

This layer should remain lightweight and free from concrete vendor dependencies.

### 2. Core

The core layer contains reusable orchestration logic that depends on abstractions, not providers.

Implemented now:

- deterministic in-memory chat behavior;
- deterministic SHA-256-derived embedding generation for examples and tests.

Future orchestration, retry policies, common result models, and shared domain services should be added only when there is implemented behavior that requires them.

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

## Current Architecture Scope

The implemented reusable surface is intentionally small:

- chat abstractions and models;
- provider-independent embedding contracts and models;
- deterministic chat and embedding implementations for tests/examples;
- a minimal runnable chat sample;
- CI validation for build and tests.

Vector-store contracts, provider SDK adapters, RAG orchestration, and document ingestion remain future work. The goal is to grow the toolkit from proven use cases instead of publishing a speculative framework surface.

---

## Portfolio Message

This architecture demonstrates enterprise-ready AI backend thinking: separation of concerns, provider independence, testability, and a clear path from demo to production.
