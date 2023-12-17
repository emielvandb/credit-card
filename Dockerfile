# Use the .NET SDK 3.1 as the base image for building
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

# Set the working directory inside the container
WORKDIR /app

# Copy all files to the container
COPY . .

# Restore dependencies and build the application
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Create a runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime

# Set the working directory in the runtime container
WORKDIR /app

# Copy the build output from the previous stage
COPY --from=build /app/out ./

# Expose the port your app runs on
EXPOSE 80

# Define the entry point for the application
ENTRYPOINT ["dotnet", "Application_CreditCard.dll"]
