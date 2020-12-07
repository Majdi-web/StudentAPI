FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["Kubernetes8.csproj", "./"]

RUN dotnet restore "./Kubernetes8.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Kubernetes8.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Kubernetes8.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Kubernetes8.dll"]