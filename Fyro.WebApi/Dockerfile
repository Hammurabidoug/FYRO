#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Fyro.WebApi/Fyro.WebApi.csproj", "Fyro.WebApi/"]
COPY ["Fyro.Client.BlazorWeb/FYRO.Business/FYRO.Business.csproj", "Fyro.Client.BlazorWeb/FYRO.Business/"]
COPY ["Fyro.DependencyInjection/Fyro.DependencyInjection.csproj", "Fyro.DependencyInjection/"]
COPY ["Fyro.Data.Abstractions/Fyro.Data.Abstractions.csproj", "Fyro.Data.Abstractions/"]
COPY ["FYRO.Data.SqlServer/FYRO.Data.SqlServer.csproj", "FYRO.Data.SqlServer/"]
COPY ["Fyro.Data/Fyro.Data.csproj", "Fyro.Data/"]
RUN dotnet restore "Fyro.WebApi/Fyro.WebApi.csproj"
COPY . .
WORKDIR "/src/Fyro.WebApi"
RUN dotnet build "Fyro.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Fyro.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Fyro.WebApi.dll"]