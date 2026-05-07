# VioNet CFDI

Lightweight ERP-style backend project focused on CFDI-related workflows, expense tracking, reporting, and fiscal domain experimentation using ASP.NET Core and SQL Server.

## Current Stack

- Docker
- Microsoft SQL Server 2022
- VS Code SQL tooling

## SQL Server

Current environment:

- SQL Server 2022 Developer Edition
- Linux container (Ubuntu 22.04)
- Docker Compose setup
- Port: `1433`

Verified version:

```sql
Microsoft SQL Server 2022 (RTM-CU24-GDR)
16.0.4250.1 (X64)
Developer Edition for Linux
```

## Project Structure

```text
.
├── backend
├── database
├── docker
├── docs
└── frontend
```

## Docker

Start SQL Server container:

```bash
cd docker
docker compose up -d
```

Stop services:

```bash
docker compose down
```

## Environment Variables

Create a `.env` file inside `docker/`.

Example:

```env
ACCEPT_EULA=Y
MSSQL_SA_PASSWORD=ExamplePasswordTest@1234
```