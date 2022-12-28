dotnet pack --configuration Release

dotnet nuget push "./bin/Release/Cthulhu-tech.PowerCollections.0.0.3-beta.nupkg" --source github --api-key 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
