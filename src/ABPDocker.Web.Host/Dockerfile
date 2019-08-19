FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/ABPDocker.Web.Host/ABPDocker.Web.Host.csproj", "src/ABPDocker.Web.Host/"]
COPY ["src/ABPDocker.Web.Core/ABPDocker.Web.Core.csproj", "src/ABPDocker.Web.Core/"]
COPY ["src/ABPDocker.EntityFrameworkCore/ABPDocker.EntityFrameworkCore.csproj", "src/ABPDocker.EntityFrameworkCore/"]
COPY ["src/ABPDocker.Core/ABPDocker.Core.csproj", "src/ABPDocker.Core/"]
COPY ["src/ABPDocker.Application/ABPDocker.Application.csproj", "src/ABPDocker.Application/"]
RUN dotnet restore "src/ABPDocker.Web.Host/ABPDocker.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/ABPDocker.Web.Host"
RUN dotnet build "ABPDocker.Web.Host.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ABPDocker.Web.Host.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ABPDocker.Web.Host.dll"]
