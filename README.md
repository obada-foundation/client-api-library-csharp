# Obada.Client - the C# library for the OBADA Client Helper API

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 0.0.1
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://www.obada.io](https://www.obada.io)

## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Obada.Client.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ObitApi(Configuration.Default);
            var obitDid = new ObitDid(); // ObitDid |  (optional) 

            try
            {
                // Download Obit from Blockchain
                ClientObitResponse result = apiInstance.DownloadObitFromChain(obitDid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.DownloadObitFromChain: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ObitApi* | [**DownloadObitFromChain**](docs/ObitApi.md#downloadobitfromchain) | **POST** /api/server/obit/download | Download Obit from Blockchain
*ObitApi* | [**FetchObitFromChain**](docs/ObitApi.md#fetchobitfromchain) | **GET** /api/server/obit/{obit_did} | Get Obit From Blockchain
*ObitApi* | [**GenerateObitDef**](docs/ObitApi.md#generateobitdef) | **GET** /api/obit/definition | Generate Obit Definition
*ObitApi* | [**GenerateRootHash**](docs/ObitApi.md#generateroothash) | **POST** /api/obit/hash | Generates The Root Hash using the data provided.
*ObitApi* | [**GetClientObit**](docs/ObitApi.md#getclientobit) | **GET** /api/client/obit/{obit_did} | Get Client Obit
*ObitApi* | [**SaveClientObit**](docs/ObitApi.md#saveclientobit) | **POST** /api/client/obit | Save Client Obit
*ObitApi* | [**UploadObit**](docs/ObitApi.md#uploadobit) | **POST** /api/server/obit/upload | Upload Obit to Blockchain


## Documentation for Models

 - [Model.BaseResponse](docs/BaseResponse.md)
 - [Model.BlockChainObit](docs/BlockChainObit.md)
 - [Model.BlockChainObitResponse](docs/BlockChainObitResponse.md)
 - [Model.ClientObit](docs/ClientObit.md)
 - [Model.ClientObitResponse](docs/ClientObitResponse.md)
 - [Model.LocalObit](docs/LocalObit.md)
 - [Model.LocalObitDocuments](docs/LocalObitDocuments.md)
 - [Model.LocalObitMetadata](docs/LocalObitMetadata.md)
 - [Model.LocalObitStructuredData](docs/LocalObitStructuredData.md)
 - [Model.ObitDefinition](docs/ObitDefinition.md)
 - [Model.ObitDefinitionResponse](docs/ObitDefinitionResponse.md)
 - [Model.ObitDid](docs/ObitDid.md)
 - [Model.RootHashResponse](docs/RootHashResponse.md)


## Documentation for Authorization

All endpoints do not require authorization.
