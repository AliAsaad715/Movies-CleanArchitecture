# 🎬 Clean Architecture Movies API with CQRS

A modern, scalable movie management system built with **.NET** implementing **Clean Architecture** and **CQRS** design patterns.

## 🏗️ Architecture Overview

This project follows **Clean Architecture** principles with a clear separation of concerns:
┌─────────────────────────────────────────────┐

│ PRESENTATION │

│ (API Controllers) │

├─────────────────────────────────────────────┤

│ APPLICATION │

│ (Commands, Queries, Handlers) │

├─────────────────────────────────────────────┤

│ Core │

│ (Entities, Value Objects) │

├─────────────────────────────────────────────┤

│ INFRASTRUCTURE │

│ (Persistence, External Services) │
└─────────────────────────────────────────────┘


## 🚀 Technologies & Patterns

- **.NET 9.0** - Latest LTS version
- **Clean Architecture** - Separation of concerns
- **CQRS (Command Query Responsibility Segregation)** - Separation of read and write operations
- **MediatR** - Mediator pattern implementation
- **Entity Framework Core** - Database access
- **AutoMapper** - Object mapping
- **FluentValidation** - Input validation
- **SQL Server** - Primary database
- **Swagger/OpenAPI** - API documentation
