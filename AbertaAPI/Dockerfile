FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /App

COPY ./src/ ./
RUN dotnet restore AbertaAPI.sln
RUN dotnet publish -c Release -o out Aberta.API/Aberta.API.csproj

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY --from=build-env /App/out .
ENTRYPOINT ["dotnet", "Aberta.API.dll"]
