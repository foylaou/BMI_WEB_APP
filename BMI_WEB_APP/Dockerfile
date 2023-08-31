FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["BMI_WEB_APP/BMI_WEB_APP.csproj", "BMI_WEB_APP/"]
RUN dotnet restore "BMI_WEB_APP/BMI_WEB_APP.csproj"
COPY . .
WORKDIR "/src/BMI_WEB_APP"
RUN dotnet build "BMI_WEB_APP.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BMI_WEB_APP.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BMI_WEB_APP.dll"]
