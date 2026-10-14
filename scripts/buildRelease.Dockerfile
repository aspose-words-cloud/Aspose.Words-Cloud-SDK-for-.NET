FROM mcr.microsoft.com/dotnet/sdk:9.0

RUN apt-get -o APT::Sandbox::User=root update && apt-get -o APT::Sandbox::User=root install -y --no-install-recommends osslsigncode && rm -rf /var/lib/apt/lists/*

WORKDIR /build
ENV NUGET_PACKAGES=/build/.nuget/packages
COPY . .
RUN dotnet build Aspose.Words.Cloud.Sdk.sln -c Release
RUN chmod -R a+rwX /build
