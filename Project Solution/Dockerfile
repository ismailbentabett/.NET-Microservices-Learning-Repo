
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

# Copy the entire solution folder into the working directory
COPY . ./

WORKDIR /app/CommandService

RUN dotnet restore


RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app/CommandService
COPY --from=build-env /app/CommandService/out .
ENTRYPOINT ["dotnet", "CommandService.dll"]
