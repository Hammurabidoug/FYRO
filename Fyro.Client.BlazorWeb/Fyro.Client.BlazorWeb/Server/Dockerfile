#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Fyro.Client.BlazorWeb/Fyro.Client.BlazorWeb/Server/Fyro.Web.Blazor.Server.csproj", "Fyro.Client.BlazorWeb/Fyro.Client.BlazorWeb/Server/"]
COPY ["Fyro.Client.BlazorWeb/Fyro.Client.BlazorWeb/Shared/Fyro.Web.Blazor.Shared.csproj", "Fyro.Client.BlazorWeb/Fyro.Client.BlazorWeb/Shared/"]
COPY ["Fyro.Client.BlazorWeb/Fyro.Client.BlazorWeb/Client/Fyro.Web.Blazor.Client.csproj", "Fyro.Client.BlazorWeb/Fyro.Client.BlazorWeb/Client/"]
COPY ["Fyro.Client.BlazorWeb/FYRO.Business/FYRO.Business.csproj", "Fyro.Client.BlazorWeb/FYRO.Business/"]
RUN dotnet restore "Fyro.Client.BlazorWeb/Fyro.Client.BlazorWeb/Server/Fyro.Web.Blazor.Server.csproj"
COPY . .
WORKDIR "/src/Fyro.Client.BlazorWeb/Fyro.Client.BlazorWeb/Server"
RUN dotnet build "Fyro.Web.Blazor.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Fyro.Web.Blazor.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Fyro.Web.Blazor.Server.dll"]