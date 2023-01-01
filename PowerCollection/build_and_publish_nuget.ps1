dotnet pack --configuration Release

cd ./bin/Release/

$path = Get-ChildItem -Path Cthulhu-tech.PowerCollections.[0-9].[0-9].[0-9]-beta.nupkg

$path = $path[-1].fullname | Sort-Object LastAccessTime

dotnet nuget push $path --source github --api-key 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
