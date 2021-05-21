#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Afonsoft.Ranking.Migrator/Afonsoft.Ranking.Migrator.csproj", "src/Afonsoft.Ranking.Migrator/"]
COPY ["src/Afonsoft.Ranking.EntityFrameworkCore/Afonsoft.Ranking.EntityFrameworkCore.csproj", "src/Afonsoft.Ranking.EntityFrameworkCore/"]
COPY ["src/Afonsoft.Ranking.Core/Afonsoft.Ranking.Core.csproj", "src/Afonsoft.Ranking.Core/"]
COPY ["src/Afonsoft.Ranking.Core.Shared/Afonsoft.Ranking.Core.Shared.csproj", "src/Afonsoft.Ranking.Core.Shared/"]
RUN dotnet restore "src/Afonsoft.Ranking.Migrator/Afonsoft.Ranking.Migrator.csproj"
COPY . .
WORKDIR "/src/src/Afonsoft.Ranking.Migrator"
RUN dotnet build "Afonsoft.Ranking.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Afonsoft.Ranking.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Afonsoft.Ranking.Migrator.dll"]
