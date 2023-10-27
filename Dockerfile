FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base

WORKDIR /app

EXPOSE 80

EXPOSE 443


FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src

COPY HortiDot.csproj /src

RUN dotnet restore "./HortiDot.csproj"

COPY . .

RUN dotnet build HortiDot.csproj -c Release -o /app/build


FROM build AS publish

RUN dotnet publish HortiDot.csproj -c Release -o /app/publish /p:UseAppHost=false


FROM base AS final

WORKDIR /app

COPY --from=publish /app/publish /app

ENTRYPOINT ["dotnet", "HortiDot.dll"