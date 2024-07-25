# Banking System Project

## Overview

In this project, I developed a banking system with three distinct personas. The project involved several key technologies and architectural patterns to ensure efficiency and scalability.

## Core Technologies

- **C#**: The primary programming language used to build the system.
- **SQL Server**: The database system used to store and manage data.
- **Swagger**: Utilized for API documentation and testing.

## Project Structure

I organized the project into separate layers to enhance maintainability and scalability:
- **Core Data Layer**: Handles all data-related operations and database interactions.
- **Service Layer**: Contains the business logic and services used by the application.

## Key Features

1. **Asynchronous Operations**: Implemented asynchronous methods to improve performance and responsiveness.
2. **Dependency Injection**: Used `AddDbContext` to configure the database context and `AddScoped` to manage the lifetime of services.
3. **Database Migrations**: Connected to SQL Server and created migrations for every schema change, ensuring that the database schema evolves with the application.

## Implementation Details

- **AddDbContext**: Configured the database context to enable Entity Framework Core to interact with SQL Server.
- **AddScoped**: Registered services with a scoped lifetime to ensure they are created once per request.
- **Swagger**: Integrated Swagger for comprehensive API documentation, making it easier to test and debug the API endpoints.

By leveraging these technologies and best practices, I developed a robust and scalable banking system that efficiently manages operations across multiple personas. The use of asynchronous operations and structured project layers ensures the system is responsive and easy to maintain.
