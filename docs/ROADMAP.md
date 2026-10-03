# Roadmap

## v0.1 - Chat Foundations

Goal: Establish the project structure and a small provider-independent chat boundary.

Completed:
- Solution structure
- Chat request/response models
- In-memory chat provider
- Minimal console sample
- Unit tests and CI

## v0.2 - Retrieval Contracts

Goal: Introduce only the reusable contracts needed for deterministic retrieval foundations.

Completed:
- Provider-independent embedding generator contract
- Single and multi-input embedding request/response models
- Stable input-to-output identifier mapping
- Explicit vector dimensions
- Deterministic local embedding provider
- Cancellation and validation tests

Remaining:
- Vector-store abstraction justified by a runnable use case
- Deterministic retrieval example
- Error behavior for retrieval/storage boundaries
- Documentation for the completed retrieval path

## v0.3 - Document Example

Goal: Add document-focused contracts only after the retrieval boundary is proven.

Planned:
- Document-ingestion contracts justified by a runnable sample
- Text chunking example
- Source-attribution models
- Small end-to-end retrieval demonstration

## Later Milestones

Potential provider packages, ASP.NET Core APIs, persistence, observability, and deployment guidance remain intentionally uncommitted until corresponding implementations and tests exist.

## Release Principle

A capability is documented as implemented only when code, tests, and a reviewable example or contract exist. Production-readiness claims are out of scope for the current toolkit.
