FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["TeleECM.Office/TeleECM.Office.csproj", "TeleECM.Office/"]
RUN dotnet restore "TeleECM.Office/TeleECM.Office.csproj"
COPY . .
WORKDIR "/src/TeleECM.Office"
RUN dotnet build "TeleECM.Office.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "TeleECM.Office.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TeleECM.Office.dll"]