# Obada.Client - the C# library for the OBADA API

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

            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);

            try
            {
                // Shows account balance of OBADA address
                AccountBalance result = apiInstance.Balance();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountsApi.Balance: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *http://obs.node.obada.io*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountsApi* | [**Balance**](docs/AccountsApi.md#balance) | **GET** /accounts/my-balance | Shows account balance of OBADA address
*AccountsApi* | [**CreateAccount**](docs/AccountsApi.md#createaccount) | **POST** /accounts | Creates a new Account
*NFTApi* | [**Mint**](docs/NFTApi.md#mint) | **POST** /nft/{key}/mint | Mints NFT
*NFTApi* | [**Nft**](docs/NFTApi.md#nft) | **GET** /nft/{key} | Fetch NFT from OBADA blockchain Node
*NFTApi* | [**Send**](docs/NFTApi.md#send) | **POST** /nft/{key}/send | Send NFT to another address
*NFTApi* | [**UpdateMetadata**](docs/NFTApi.md#updatemetadata) | **POST** /nft/{key}/metadata | Update NFT metadata
*ObitApi* | [**Get**](docs/ObitApi.md#get) | **GET** /obits/{key} | Get Obit by DID or USN
*ObitApi* | [**History**](docs/ObitApi.md#history) | **GET** /obits/{key}/history | Get Obit history by DID or USN
*ObitApi* | [**Save**](docs/ObitApi.md#save) | **POST** /obits | Save Obit
*ObitApi* | [**Search**](docs/ObitApi.md#search) | **GET** /obits | Search obits by query
*UtilsApi* | [**GenerateChecksum**](docs/UtilsApi.md#generatechecksum) | **POST** /obit/checksum | Generates Obit checksum
*UtilsApi* | [**GenerateDID**](docs/UtilsApi.md#generatedid) | **POST** /obit/did | Generate Obit DID


## Documentation for Models

 - [Model.Account](docs/Account.md)
 - [Model.AccountBalance](docs/AccountBalance.md)
 - [Model.DeviceDocument](docs/DeviceDocument.md)
 - [Model.Document](docs/Document.md)
 - [Model.GenerateObitChecksumRequest](docs/GenerateObitChecksumRequest.md)
 - [Model.GenerateObitChecksumResponse](docs/GenerateObitChecksumResponse.md)
 - [Model.GenerateObitDIDRequest](docs/GenerateObitDIDRequest.md)
 - [Model.GenerateObitDIDResponse](docs/GenerateObitDIDResponse.md)
 - [Model.History200Response](docs/History200Response.md)
 - [Model.InternalServerError](docs/InternalServerError.md)
 - [Model.NFT](docs/NFT.md)
 - [Model.NFTData](docs/NFTData.md)
 - [Model.NFTDocument](docs/NFTDocument.md)
 - [Model.NewAccountRequest](docs/NewAccountRequest.md)
 - [Model.NotAuthorized](docs/NotAuthorized.md)
 - [Model.NotFound](docs/NotFound.md)
 - [Model.Obit](docs/Obit.md)
 - [Model.ObitHistory](docs/ObitHistory.md)
 - [Model.Obits](docs/Obits.md)
 - [Model.ObitsMeta](docs/ObitsMeta.md)
 - [Model.SaveObitRequest](docs/SaveObitRequest.md)
 - [Model.SendNFTRequest](docs/SendNFTRequest.md)
 - [Model.UnprocessableEntity](docs/UnprocessableEntity.md)
 - [Model.UnprocessableEntityFieldsInner](docs/UnprocessableEntityFieldsInner.md)


## Documentation for Authorization


### bearerAuth


- **Type**: HTTP bearer authentication

