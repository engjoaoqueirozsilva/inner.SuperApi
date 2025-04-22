# Fase base (para executar a aplicação)
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Fase de build (compilar o código)
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copiar os arquivos de projeto e restaurar dependências
COPY ["src/inner.masterApi.Web.Host/inner.masterApi.Web.Host.csproj", "src/inner.masterApi.Web.Host/"]
COPY ["src/inner.masterApi.Migrator/inner.masterApi.Migrator.csproj", "src/inner.masterApi.Migrator/"]
COPY ["src/inner.masterApi.Application/inner.masterApi.Application.csproj", "src/inner.masterApi.Application/"]
COPY ["src/inner.masterApi.Core/inner.masterApi.Core.csproj", "src/inner.masterApi.Core/"]
COPY ["src/inner.masterApi.EntityFrameworkCore/inner.masterApi.EntityFrameworkCore.csproj", "src/inner.masterApi.EntityFrameworkCore/"]
COPY ["src/inner.masterApi.Web.Core/inner.masterApi.Web.Core.csproj", "src/inner.masterApi.Web.Core/"]

RUN dotnet restore "./src/inner.masterApi.Web.Host/inner.masterApi.Web.Host.csproj"

# Copiar o restante do código
COPY . .

# Trabalhar na pasta do Web Host e fazer o build
WORKDIR "/src/src/inner.masterApi.Web.Host"
RUN dotnet build "./inner.masterApi.Web.Host.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Fase de publicação
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./inner.masterApi.Web.Host.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Fase final (para executar a aplicação no contêiner)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "inner.masterApi.Web.Host.dll"]
