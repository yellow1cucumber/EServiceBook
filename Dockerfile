FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["EServiceBook.csproj", "."]
COPY ["Domain.Core/Domain.Core.csproj", "Domain.Core/"]
COPY ["DAL/DAL.csproj", "DAL/"]
RUN dotnet restore "./EServiceBook.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./EServiceBook.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./EServiceBook.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EServiceBook.dll"]