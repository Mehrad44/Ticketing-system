FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY TicketingSystem.Api/TicketingSystem.Api.csproj TicketingSystem.Api/
COPY TicketingSystem.Application/TicketingSystem.Application.csproj TicketingSystem.Application/
COPY TicketingSystem.Infrastructure/TicketingSystem.Infrastructure.csproj TicketingSystem.Infrastructure/
COPY TicketingSystem.Domain/TicketingSystem.Domain.csproj TicketingSystem.Domain/

RUN dotnet restore TicketingSystem.Api/TicketingSystem.Api.csproj

COPY . .
WORKDIR /src/TicketingSystem.Api
RUN dotnet publish -c Release -o /app/publish

