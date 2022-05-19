FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /source

COPY *.sln .
COPY ["tests/MovieCentral.IntegrationTests/MovieCentral.IntegrationTests.csproj", "tests/MovieCentral.IntegrationTests/"]
COPY ["src/MovieCentral.Server/MovieCentral.Server.csproj", "src/MovieCentral.Server/"]
COPY ["src/MovieCentral.Client/MovieCentral.Client.csproj", "src/MovieCentral.Client/"]
COPY ["src/MovieCentral.Shared/MovieCentral.Shared.csproj", "src/MovieCentral.Shared/"]
COPY ["src/MovieCentral.Infrastructure/MovieCentral.Infrastructure.csproj", "src/MovieCentral.Infrastructure/"]
COPY ["src/MovieCentral.Domain/MovieCentral.Domain.csproj", "src/MovieCentral.Domain/"]
COPY ["src/MovieCentral.Application/MovieCentral.Application.csproj", "src/MovieCentral.Application/"]
RUN dotnet restore

# Copy the full solution over
COPY . .
# Make sure there are no formatting issues before building (lint)
RUN dotnet format --no-restore --verify-no-changes
RUN dotnet build
# Run all our integration tests
RUN dotnet test

# Create the EntityFramework Core Migrations Bundle
From build as migrations
WORKDIR /source/src/MovieCentral.Server
RUN dotnet tool install --global dotnet-ef
ENV PATH $PATH:/root/.dotnet/tools
RUN dotnet ef migrations bundle --self-contained -r linux-x64 --force

# Publish the Server project
FROM build AS publish
WORKDIR /source/src/MovieCentral.Server
RUN dotnet publish -c Release -o out

# The app itself
FROM base AS final
WORKDIR /app
COPY --from=publish /source/src/MovieCentral.Server/out ./
# Migrate and create our SQLite database using the EF bundle we created
COPY --from=migrations /source/src/MovieCentral.Server/efbundle .
RUN /app/efbundle
RUN rm /app/efbundle
ENTRYPOINT ["dotnet", "MovieCentral.Server.dll"]
