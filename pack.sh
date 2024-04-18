#!/bin/sh
cd ./Build
dotnet build ../Facepunch.Steamworks/Facepunch.Steamworks.csproj -p:TargetOS=windows -o ../bin/windows
dotnet build ../Facepunch.Steamworks/Facepunch.Steamworks.csproj -p:TargetOS=unix -o ../bin/unix
nuget pack ./Facepunch.Steamworks.nuspec -OutputDirectory ../bin