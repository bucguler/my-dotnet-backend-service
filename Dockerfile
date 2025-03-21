# Use the official .NET 9.0 SDK image as the build environment
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env
WORKDIR /app

# Copy the csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the application and build
COPY . ./
RUN dotnet publish -c Release -o out

# Use the official .NET runtime image as the runtime environment
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build-env /app/out .

# Expose port 80 for HTTP
EXPOSE 80

# Set the entry point for the application
ENTRYPOINT ["dotnet", "my-dotnet-backend-service.dll"]