FROM mcr.microsoft.com/dotnet/sdk:8.0 as build-env
WORKDIR /app

COPY BooksAPI/*.csproj ./BooksAPI/

WORKDIR /app/BooksAPI
RUN dotnet restore

COPY BooksAPI/ ./

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build-env /app/BooksAPI/out .

ENV ASPNETCORE_URLS=https://+:80
ENTRYPOINT [ "dotnet", "BooksAPI.dll" ]

