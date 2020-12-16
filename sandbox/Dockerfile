FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
EXPOSE 80
EXPOSE 443
WORKDIR /app
COPY out .
ENTRYPOINT ["dotnet", "Sandbox.Webapi.dll"]
