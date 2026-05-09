# Vionet CFDI

Lightweight ERP-style backend project focused on CFDI-related workflows, expense tracking, reporting, and fiscal domain experimentation using ASP.NET Core and SQL Server.

## Stack

![.NET](https://img.shields.io/badge/.NET-9.0-512BD4?logo=dotnet)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-Web_API-512BD4?logo=dotnet)
![SQL Server](https://img.shields.io/badge/SQL_Server-2022-CC2927?logo=microsoftsqlserver)
![Docker](https://img.shields.io/badge/Docker-Containerized-2496ED?logo=docker)
![EF Core](https://img.shields.io/badge/EF_Core-ORM-6DB33F)
![Clean Architecture](https://img.shields.io/badge/Architecture-Clean-8A2BE2)

## Documentation

Project documentation and setup guides are available here:

* [docs/README.md](docs/README.md)

## Current Capabilities

* ASP.NET Core Web API
* Entity Framework Core integration
* SQL Server 2022 support
* Dockerized local development environment
* Configurable startup migrations and seeding
* Persistent SQL Server Docker volumes

## Development

Run the full local environment:

```bash
docker compose up --build
```
