FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/ASPExample/ASPExample.csproj", "ASPExample/"]
RUN dotnet restore "src/ASPExample/ASPExample.csproj"
COPY . .
WORKDIR "/src/ASPExample"
RUN dotnet build "ASPExample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ASPExample.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ASPExample.dll"]
