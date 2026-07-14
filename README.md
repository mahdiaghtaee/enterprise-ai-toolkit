# Enterprise AI Toolkit

[![.NET](https://img.shields.io/badge/.NET-8.0-blue)](https://dotnet.microsoft.com/)
[![Status](https://img.shields.io/badge/status-early--foundation-orange)](#current-status)
[![License](https://img.shields.io/badge/license-MIT-green)](LICENSE)

An early .NET foundation for experimenting with provider-independent AI contracts.

The repository currently contains a small solution structure, initial chat abstractions and models, an in-memory provider, a runnable console sample, tests, and CI. It does **not** yet contain a complete RAG pipeline, document-processing implementation, production provider integration, or deployable application framework.

## Current Purpose

The project explores how to define small, testable contracts before adding vendor-specific SDKs. It is intended to grow through implemented examples rather than a large speculative API surface.

Current focus:

- chat request and response contracts;
- provider-independent interfaces;
- an in-memory implementation for deterministic examples and tests;
- a minimal console sample;
- restore, build, and test validation in GitHub Actions.

## Run the Sample

```bash
dotnet run --project examples/ConsoleSample/ConsoleSample.csproj
```

The sample uses the in-memory provider and requires no API key or external service.

## Run the Tests

```bash
dotnet test EnterpriseAI.sln --configuration Release
```

## Repository Structure

```text
src/
  EnterpriseAI.Abstractions/   Initial contracts and models
  EnterpriseAI.Core/           Current reusable implementation code

tests/
  EnterpriseAI.Tests/          Unit and contract tests

examples/
  ConsoleSample/               Minimal runnable example

docs/
  Architecture and design notes
```

The structure should be updated only when corresponding projects and implementations exist.

## Design Principles

- keep contracts small and justified by a runnable use case;
- preserve deterministic fake or in-memory providers for tests;
- avoid coupling shared abstractions to one vendor SDK;
- add tests with each public behavior;
- document implemented behavior separately from planned work;
- prefer extracting reusable code from working applications over designing a framework in advance.

## Roadmap

### v0.1 — Chat Foundation

Current work:

- core chat abstraction;
- request and response models;
- in-memory provider;
- console sample;
- unit tests and CI.

### v0.2 — Retrieval Contracts

Planned only after the first contracts are stable:

- embedding request and response models;
- vector-store contracts;
- deterministic retrieval example;
- fake providers for tests;
- documented error and cancellation behavior.

### v0.3 — Document Example

Planned:

- document-ingestion contracts justified by a runnable sample;
- text chunking example;
- source-attribution models;
- a small end-to-end retrieval demonstration.

## Explicitly Not Implemented

The current repository does not claim to provide:

- production-ready architecture;
- complete RAG orchestration;
- PDF or OCR ingestion;
- OpenAI, Ollama, Qdrant, or other provider packages;
- authentication, authorization, persistence, observability, or deployment guidance;
- performance or quality benchmarks.

Those capabilities should be documented as implemented only after code and tests are added.

## Relationship to Enterprise AI Document Assistant

[`enterprise-ai-document-assistant`](https://github.com/mahdiaghtaee/enterprise-ai-document-assistant) is the concrete application. This toolkit should receive reusable abstractions only when they have been validated by a working implementation or a focused example.

## Current Status

Early foundation stage. The repository is useful for reviewing the initial .NET contracts, sample, and test approach, but it is not a finished framework or production package.

## Contributing

Contributions should stay small and include a runnable example or test demonstrating why a new abstraction is needed.

## License

MIT
