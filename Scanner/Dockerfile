FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /App

COPY ./src/ ./
RUN dotnet restore AbertaScanner.sln
RUN dotnet publish -c Release -o out Aberta.Scanner/AbertaScanner.csproj

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY --from=build-env /App/out .
ENTRYPOINT ["dotnet", "AbertaScanner.dll"]
