#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Fyro.Web.Blazor/Fyro.Web.Blazor.csproj", "Fyro.Web.Blazor/"]
RUN dotnet restore "Fyro.Web.Blazor/Fyro.Web.Blazor.csproj"
COPY . .
WORKDIR "/src/Fyro.Web.Blazor"
RUN dotnet build "Fyro.Web.Blazor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Fyro.Web.Blazor.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Fyro.Web.Blazor.dll"]