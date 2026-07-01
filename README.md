# Enterprise AI Toolkit

![.NET](https://img.shields.io/badge/.NET-8.0-blue)
![Architecture](https://img.shields.io/badge/Architecture-Provider--Agnostic-blue)
![RAG](https://img.shields.io/badge/RAG-Ready-orange)
![Status](https://img.shields.io/badge/status-early--foundation-orange)
![License](https://img.shields.io/badge/license-MIT-green)

A modular .NET toolkit for building enterprise AI applications with clean abstractions for LLMs, embeddings, RAG pipelines, vector search, document processing, and production-ready architecture patterns.

This repository is designed as a portfolio-grade foundation for enterprise AI engineering: small, composable, testable, and provider-independent.

---

## Problem

Many enterprise AI projects start as tightly coupled demos: one provider, one prompt, one database, and no clear path to production.

That makes the system hard to test, hard to replace, hard to scale, and risky for businesses that need long-term maintainability.

---

## Solution

Enterprise AI Toolkit provides a .NET-first foundation for building AI features with clean boundaries:

- LLM provider abstractions
- Embedding provider abstractions
- Retrieval and RAG contracts
- Document ingestion interfaces
- Vector store abstractions
- Testable core services
- Runnable examples and implementation guidance

The goal is not to hide AI behind a large framework. The goal is to make enterprise AI systems easier to structure, test, replace, and evolve.

---

## Target Use Cases

- Document question answering with RAG
- Enterprise search over internal knowledge bases
- Provider-agnostic LLM integrations
- Embedding and vector search workflows
- AI assistants connected to business systems
- Document ingestion and semantic retrieval
- Backend foundations for AI-enabled SaaS products

---

## Planned Architecture

```text
src/
  EnterpriseAI.Abstractions/        Core contracts and request/response models
  EnterpriseAI.Core/                Shared orchestration and reusable logic
  EnterpriseAI.Providers.OpenAI/    Future provider implementation
  EnterpriseAI.Providers.Ollama/    Future local model provider implementation
  EnterpriseAI.VectorStores.Qdrant/ Future vector database integration
  EnterpriseAI.RAG/                 Retrieval and answer generation pipeline
  EnterpriseAI.Documents/           Document ingestion and chunking abstractions
  EnterpriseAI.WebApi/              Optional API hosting layer

tests/
  EnterpriseAI.Tests/               Unit and contract tests

examples/
  ConsoleSample/                    Minimal runnable sample

docs/
  Architecture and usage notes
```

---

## Engineering Principles

- Provider-agnostic design
- Clean and testable abstractions
- Small modules over large frameworks
- Practical samples over theoretical examples
- Production-oriented structure
- Explicit contracts before provider implementations
- Test-first foundations for AI backend services

---

## Roadmap

### v0.1 - Foundations

- Define core chat abstraction
- Add request and response models
- Add minimal console sample
- Add unit test foundation
- Add CI workflow for build and tests
- Document architecture decisions

### v0.2 - RAG Basics

- Add document chunking contracts
- Add embedding request and response models
- Add vector store abstraction
- Add simple retrieval sample
- Add fake providers for tests

### v0.3 - Documents

- Add document ingestion abstractions
- Add PDF and text ingestion examples
- Add metadata model
- Add document search sample
- Add source attribution model

---

## Portfolio Value

This project demonstrates:

- Senior-level .NET architecture
- Enterprise AI system design
- Clean abstraction boundaries
- RAG-ready backend thinking
- Provider-independent engineering
- Testable AI application foundations

It complements [`enterprise-ai-document-assistant`](https://github.com/mahdiaghtaee/enterprise-ai-document-assistant), which is a concrete enterprise document assistant backend.

---

## Current Status

Early foundation stage. The first development milestone is `v0.1`, focused on project structure, abstractions, one runnable sample, and CI/test credibility.

---

## Author

Built by [Mahdi Aghtaee](https://github.com/mahdiaghtaee) as part of an enterprise AI and .NET backend portfolio.

---

## License

MIT
