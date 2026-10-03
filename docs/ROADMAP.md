# Roadmap

## v0.1 - Chat Foundations — Completed

Delivered:
- solution structure;
- provider-independent chat request/response models;
- in-memory chat provider;
- minimal console sample;
- unit tests and CI.

## v0.2 - Chat and Embedding Foundation — Completed

Delivered:
- provider-independent embedding generator contract;
- single and multi-input embedding request/response models;
- stable input-to-output identifier mapping;
- explicit vector dimensions;
- deterministic SHA-256-based local embedding provider;
- cancellation and validation tests;
- runnable sample and CI validation.

## Maintenance boundary

The repository is in maintenance mode after v0.2.0. No active feature milestone is currently planned.

The following are deliberately deferred rather than partially implemented:

- vector-store abstractions;
- retrieval orchestration;
- provider SDK adapters;
- document-ingestion contracts;
- text chunking and source-attribution examples;
- ASP.NET Core hosting, persistence, observability, and deployment guidance.

These items should be added only if the toolkit is intentionally resumed and a concrete, testable use case justifies the public surface.

## Release principle

A capability is documented as implemented only when code, tests, and a reviewable example or contract exist. Production-readiness claims remain out of scope.
