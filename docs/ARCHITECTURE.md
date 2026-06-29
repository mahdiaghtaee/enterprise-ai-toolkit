# Architecture

## Overview

Enterprise AI Toolkit is organized around small, replaceable modules. Each module should expose clear contracts and avoid direct coupling to a specific AI provider, vector database, or application host.

## High-Level Layers

```text
Applications
  WebApi
  Console Samples
  Worker Samples

Capabilities
  RAG
  Documents
  Vector Search
  Providers

Core
  Abstractions
  Shared Models
  Configuration
```

## Core Principles

### Provider Independence
Application code should depend on interfaces instead of direct SDK implementations.

### Replaceable Storage
Vector store and metadata storage should be replaceable through abstractions.

### Runnable Examples
Each major capability should include at least one small runnable example.

### Testable Design
Contracts and services should be easy to test without external services.

## Planned Projects

```text
EnterpriseAI.Abstractions
EnterpriseAI.Core
EnterpriseAI.Providers.OpenAI
EnterpriseAI.Providers.Ollama
EnterpriseAI.VectorStores.Qdrant
EnterpriseAI.RAG
EnterpriseAI.Documents
EnterpriseAI.WebApi
```

## v0.1 Architecture Scope

The first milestone focuses only on:
- Core models
- Provider contracts
- Embedding contracts
- A minimal sample

The goal is to keep the first version small and maintainable.
