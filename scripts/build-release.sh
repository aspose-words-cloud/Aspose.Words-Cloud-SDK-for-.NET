#!/usr/bin/env bash
set -euo pipefail

project=Aspose.Words.Cloud.Sdk/Aspose.Words.Cloud.Sdk.csproj

mkdir -p package/lib/netstandard2.0 package/License packages

dotnet build "$project" -c Release --no-restore -p:SignAssembly=true -p:AssemblyOriginatorKeyFile="$SNK_FILE" -v:q

docker run --rm \
  -v "Aspose.Words.Cloud.Sdk/bin/Release/netstandard2.0:/codesign/input" \
  --entrypoint bash \
  ghcr.io/sslcom/codesigner:latest \
  /codesign/CodeSignTool.sh sign \
  -username="$SSL_USERNAME" \
  -password="$SSL_PASSWORD" \
  -totp_secret="$SSL_SECRET" \
  -input_file_path="/codesign/input/Aspose.Words.Cloud.Sdk.dll" \
  -override

osslsigncode verify /tmp/Aspose.Words.Cloud.Sdk.dll

cp Aspose.Words.Cloud.Sdk/bin/Release/netstandard2.0/Aspose.Words.Cloud.Sdk.dll package/lib/netstandard2.0/Aspose.Words.Cloud.Sdk.dll
cp Aspose.Words.Cloud.Sdk/bin/Release/netstandard2.0/Aspose.Words.Cloud.Sdk.pdb package/lib/netstandard2.0/
cp Aspose.Words.Cloud.Sdk/bin/Release/netstandard2.0/Aspose.Words.Cloud.Sdk.xml package/lib/netstandard2.0/
cp Aspose.Words.Cloud.Sdk/bin/Release/netstandard2.0/aspose_word-for-net.png package/
cp -r License/. package/License/

dotnet pack "$project" -c Release --no-build -p:NuspecFile=/build/Aspose.Words.Cloud.Sdk/Aspose.Words-Cloud.nuspec -p:NuspecBasePath=/build/package -p:NuspecProperties="version=$SDK_VERSION" -o packages

docker run --rm \
  -v "packages:/codesign/input" \
  --entrypoint bash \
  ghcr.io/sslcom/codesigner:latest \
  /codesign/CodeSignTool.sh sign \
  -username="$SSL_USERNAME" \
  -password="$SSL_PASSWORD" \
  -totp_secret="$SSL_SECRET" \
  -input_file_path="/codesign/input/Aspose.Words-Cloud.$SDK_VERSION.nupkg" \
  -override

dotnet nuget verify "packages/Aspose.Words-Cloud.$SDK_VERSION.nupkg"
