#!/usr/bin/env bash
set -euo pipefail

project=Aspose.Words.Cloud.Sdk/Aspose.Words.Cloud.Sdk.csproj
assembly=Aspose.Words.Cloud.Sdk/bin/Release/netstandard2.0/Aspose.Words.Cloud.Sdk.dll
mkdir -p package/lib/netstandard2.0 package/License packages

dotnet build "$project" -c Release --no-restore -p:SignAssembly=true -p:AssemblyOriginatorKeyFile="$SNK_FILE" -v:q
osslsigncode sign -pkcs12 "$PFX_FILE" -pass "$PFX_PASSWORD" -in "$assembly" -out /tmp/Aspose.Words.Cloud.Sdk.dll -t 'http://timestamp.comodoca.com/?td=sha256'
osslsigncode verify /tmp/Aspose.Words.Cloud.Sdk.dll
cp /tmp/Aspose.Words.Cloud.Sdk.dll package/lib/netstandard2.0/Aspose.Words.Cloud.Sdk.dll
cp Aspose.Words.Cloud.Sdk/bin/Release/netstandard2.0/Aspose.Words.Cloud.Sdk.pdb package/lib/netstandard2.0/
cp Aspose.Words.Cloud.Sdk/bin/Release/netstandard2.0/Aspose.Words.Cloud.Sdk.xml package/lib/netstandard2.0/
cp Aspose.Words.Cloud.Sdk/bin/Release/netstandard2.0/aspose_word-for-net.png package/
cp -r License/. package/License/

dotnet pack "$project" -c Release --no-build -p:NuspecFile=/build/Aspose.Words.Cloud.Sdk/Aspose.Words-Cloud.nuspec -p:NuspecBasePath=/build/package -p:NuspecProperties="version=$SDK_VERSION" -o packages
dotnet nuget sign "packages/Aspose.Words-Cloud.$SDK_VERSION.nupkg" --certificate-path "$PFX_FILE" --certificate-password "$PFX_PASSWORD" --timestamper 'http://timestamp.comodoca.com/?td=sha256'
