#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AutoShop_API/AutoShop_API.csproj", "AutoShop_API/"]
RUN dotnet restore "AutoShop_API/AutoShop_API.csproj"
COPY . .
WORKDIR "/src/AutoShop_API"
RUN dotnet build "AutoShop_API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AutoShop_API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AutoShop_API.dll"]