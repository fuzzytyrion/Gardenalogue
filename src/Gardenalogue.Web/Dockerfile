FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Setup NodeJs
RUN apt-get update && \
    apt-get install -y wget && \
    apt-get install -y gnupg2 && \
    wget -qO- https://deb.nodesource.com/setup_10.x | bash - && \
    apt-get install -y build-essential nodejs
# End setup

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/Gardenalogue.Web/Gardenalogue.Web.csproj", "src/Gardenalogue.Web/"]
COPY ["src/Gardenalogue.Service/Gardenalogue.Service.csproj", "src/Gardenalogue.Service/"]
RUN dotnet restore "src/Gardenalogue.Web/Gardenalogue.Web.csproj"

COPY . .
WORKDIR "/src/src/Gardenalogue.Web"
RUN dotnet build "Gardenalogue.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Gardenalogue.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Gardenalogue.Web.dll"]