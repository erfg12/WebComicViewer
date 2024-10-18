# Use the official ASP.NET Core runtime image as a base
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

# Copy the published output of the ASP.NET Core application into the container
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /WebComicViewer
COPY ["WebComicViewer.csproj", "."]
RUN dotnet restore "./WebComicViewer.csproj"
COPY . .
WORKDIR "/WebComicViewer/."
RUN dotnet build "WebComicViewer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebComicViewer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebComicViewer.dll"]