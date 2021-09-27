FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["BookStore.WebApi/BookStore.WebApi.csproj", "BookStore.WebApi/"]
RUN dotnet restore "BookStore.WebApi/BookStore.WebApi.csproj"
COPY . .
WORKDIR "/src/BookStore.WebApi"
RUN dotnet build "BookStore.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BookStore.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BookStore.WebApi.dll"]
