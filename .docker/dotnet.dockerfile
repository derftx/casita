FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /workspace

COPY ./dotnet/*.service/*.csproj .
RUN dotnet restore

COPY ./dotnet/*.service .
RUN dotnet publish --configuration Release --no-restore --output out

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS deploy

WORKDIR /workspace

COPY --from=build /workspace/out .

EXPOSE 80
ENTRYPOINT [ "dotnet", "casita.service.dll" ]
