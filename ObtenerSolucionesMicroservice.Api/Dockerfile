# Consulte https://aka.ms/customizecontainer para aprender a personalizar su contenedor de depuración y cómo Visual Studio usa este Dockerfile para compilar sus imágenes para una depuración más rápida.

# Esta fase se usa cuando se ejecuta desde VS en modo rápido (valor predeterminado para la configuración de depuración)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


# Esta fase se usa para compilar el proyecto de servicio
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ObtenerSolucionesMicroservice.Api/ObtenerSolucionesMicroservice.Api.csproj", "ObtenerSolucionesMicroservice.Api/"]
COPY ["ObtenerSolucionesMicroservice.Domain/ObtenerSolucionesMicroservice.Domain.csproj", "ObtenerSolucionesMicroservice.Domain/"]
COPY ["ObtenerSolucionesMicroservice.Entities/ObtenerSolucionesMicroservice.Entities.csproj", "ObtenerSolucionesMicroservice.Entities/"]
COPY ["ObtenerSolucionesMicroservice.Exceptions/ObtenerSolucionesMicroservice.Exceptions.csproj", "ObtenerSolucionesMicroservice.Exceptions/"]
COPY ["Util/Util.csproj", "Util/"]
COPY ["ObtenerSolucionesMicroservice.Repository/ObtenerSolucionesMicroservice.Repository.csproj", "ObtenerSolucionesMicroservice.Repository/"]
COPY ["ObtenerSolucionesMicroservice.Infraestructure/ObtenerSolucionesMicroservice.Infraestructure.csproj", "ObtenerSolucionesMicroservice.Infraestructure/"]
RUN dotnet restore "./ObtenerSolucionesMicroservice.Api/ObtenerSolucionesMicroservice.Api.csproj"
COPY . .
WORKDIR "/src/ObtenerSolucionesMicroservice.Api"
RUN dotnet build "./ObtenerSolucionesMicroservice.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Esta fase se usa para publicar el proyecto de servicio que se copiará en la fase final.
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ObtenerSolucionesMicroservice.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Esta fase se usa en producción o cuando se ejecuta desde VS en modo normal (valor predeterminado cuando no se usa la configuración de depuración)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ObtenerSolucionesMicroservice.Api.dll"]