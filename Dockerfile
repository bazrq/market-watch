# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app
    
# Copy csproj and restore as distinct layers
COPY ./market-watcher.api/market-watcher.api.csproj ./
RUN dotnet restore
    
# Copy everything else and build
COPY ./market-watcher.api/ ./
RUN ls
RUN dotnet publish
    
# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "aspnetapp.dll"]