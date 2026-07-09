
# Gamestore.api

Gamestore.api is a minimal Web API implemented with .NET 10 that exposes CRUD endpoints for a simple game catalog. 
It uses Entity Framework Core for persistence and follows a small, folder-based organization to keep API, DTOs, entities and mapping logic separated.

## Overview

- Technology: .NET 10, ASP.NET Core minimal APIs
- ORM: Entity Framework Core (migrations supported)
- Purpose: Demonstrate a small REST API for managing games (list, get, create, update, delete)

## Project structure (key folders)

- Endpoints/ — minimal API route groups (e.g. GamesEndpoints.cs)
- Data/ — DbContext and database configuration (GameStoreContext)
- Entities/ — EF entity classes (Game, Genre, ...)
- Dtos/ — DTOs used for requests/responses (CreateGameDto, UpdateGameDto, GameSummaryDto)
- Mapping/ — mapping helpers or extension methods to convert between entities and DTOs
- Migrations/ — EF Core migrations (generated after running `dotnet ef migrations add`)

## Important routes

- GET  /games         — returns list of games
- GET  /games/{id}    — returns details for a game
- POST /games         — creates a new game
- PUT  /games/{id}    — updates an existing game
- DELETE /games/{id}  — removes a game

The endpoints are implemented as a route group named "games" in Endpoints/GamesEndpoints.cs.

## Getting started

Prerequisites: .NET 10 SDK installed.

1. Clone the repository.
2. Configure the database connection string in appsettings.json or via the environment variable used 
1. by the project (typically `ConnectionStrings:DefaultConnection`).
3. (Optional) Create and apply migrations:

   dotnet tool install --global dotnet-ef
   dotnet ef migrations add InitialCreate --project Gamestore.api
   dotnet ef database update --project Gamestore.api

4. Run the API locally:

   dotnet run --project Gamestore.api

The API will start on the configured port (see output or launchSettings). Use Swagger (if enabled) or 
a tool like curl/Postman/HTTP REPL to call the endpoints.

## Database and seeding

GameStoreContext (in Data/) configures the game and genre entities. Add seed data in the DbContext 
OnModelCreating or via a separate seeding step if desired.

## Tests

If unit/integration tests exist in the solution, run them with:

   dotnet test

## Contributing

Suggested workflow:

1. Create a feature branch from main.
2. Add small commits and push.
3. Open a pull request for review.

Keep changes focused and include tests for new behavior.

## License

Public

