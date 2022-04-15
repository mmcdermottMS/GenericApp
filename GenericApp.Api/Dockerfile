#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GenericApp.Api/GenericApp.Api.csproj", "GenericApp.Api/"]
COPY ["GenericApp.Domain/GenericApp.Domain.csproj", "GenericApp.Domain/"]
RUN dotnet restore "GenericApp.Api/GenericApp.Api.csproj"
COPY . .
WORKDIR "/src/GenericApp.Api"
RUN dotnet build "GenericApp.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GenericApp.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GenericApp.Api.dll"]