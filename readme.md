# A simple game written by me and my brother

build: `dotnet build`

## Make the installer

`dotnet tool install --global dotnet-warp`

`dotnet-warp game\game.csproj -o installer.exe --verbose`
