#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Afonsoft.Ranking.Web.Mvc/Afonsoft.Ranking.Web.Mvc.csproj", "src/Afonsoft.Ranking.Web.Mvc/"]
COPY ["src/Afonsoft.Ranking.Web.Core/Afonsoft.Ranking.Web.Core.csproj", "src/Afonsoft.Ranking.Web.Core/"]
COPY ["src/Afonsoft.Ranking.Application/Afonsoft.Ranking.Application.csproj", "src/Afonsoft.Ranking.Application/"]
COPY ["src/Afonsoft.Ranking.Application.Shared/Afonsoft.Ranking.Application.Shared.csproj", "src/Afonsoft.Ranking.Application.Shared/"]
COPY ["src/Afonsoft.Ranking.Core.Shared/Afonsoft.Ranking.Core.Shared.csproj", "src/Afonsoft.Ranking.Core.Shared/"]
COPY ["src/Afonsoft.Ranking.Core/Afonsoft.Ranking.Core.csproj", "src/Afonsoft.Ranking.Core/"]
COPY ["src/Afonsoft.Ranking.EntityFrameworkCore/Afonsoft.Ranking.EntityFrameworkCore.csproj", "src/Afonsoft.Ranking.EntityFrameworkCore/"]
COPY ["src/Afonsoft.Ranking.GraphQL/Afonsoft.Ranking.GraphQL.csproj", "src/Afonsoft.Ranking.GraphQL/"]
RUN dotnet restore "src/Afonsoft.Ranking.Web.Mvc/Afonsoft.Ranking.Web.Mvc.csproj"
COPY . .
WORKDIR "/src/src/Afonsoft.Ranking.Web.Mvc"
RUN dotnet build "Afonsoft.Ranking.Web.Mvc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Afonsoft.Ranking.Web.Mvc.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Afonsoft.Ranking.Web.Mvc.dll"]
