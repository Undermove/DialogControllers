FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/DialogControllers.Example/DialogControllers.Example.csproj", "DialogControllers.Example/"]
RUN dotnet restore "src/DialogControllers.Example/DialogControllers.Example.csproj"
COPY . .
WORKDIR "/src/DialogControllers.Example"
RUN dotnet build "DialogControllers.Example.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DialogControllers.Example.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DialogControllers.Example.dll"]
