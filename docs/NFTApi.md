# Obada.Client.Api.NFTApi

All URIs are relative to *http://obs.node.obada.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Mint**](NFTApi.md#mint) | **POST** /nft/{key}/mint | Mints NFT
[**Nft**](NFTApi.md#nft) | **GET** /nft/{key} | Fetch NFT from OBADA blockchain Node
[**Send**](NFTApi.md#send) | **POST** /nft/{key}/send | Send NFT to another address
[**UpdateMetadata**](NFTApi.md#updatemetadata) | **POST** /nft/{key}/metadata | Update NFT metadata



## Mint

> void Mint (string key)

Mints NFT

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class MintExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NFTApi(Configuration.Default);
            var key = did:obada:fe096095-e0f0-4918-9607-6567bd5756b5;  // string | The given ObitDID or USN argument

            try
            {
                // Mints NFT
                apiInstance.Mint(key);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NFTApi.Mint: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The given ObitDID or USN argument | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Succesfully minted |  -  |
| **404** | The requested resource could not be found. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Nft

> NFT Nft (string key)

Fetch NFT from OBADA blockchain Node

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class NftExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NFTApi(Configuration.Default);
            var key = did:obada:fe096095-e0f0-4918-9607-6567bd5756b5;  // string | The given ObitDID or USN argument

            try
            {
                // Fetch NFT from OBADA blockchain Node
                NFT result = apiInstance.Nft(key);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NFTApi.Nft: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The given ObitDID or USN argument | 

### Return type

[**NFT**](NFT.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | NFT hosted by blockchain |  -  |
| **404** | The requested resource could not be found. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Send

> void Send (string key, SendNFTRequest sendNFTRequest = null)

Send NFT to another address

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class SendExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NFTApi(Configuration.Default);
            var key = did:obada:fe096095-e0f0-4918-9607-6567bd5756b5;  // string | The given ObitDID or USN argument
            var sendNFTRequest = new SendNFTRequest(); // SendNFTRequest |  (optional) 

            try
            {
                // Send NFT to another address
                apiInstance.Send(key, sendNFTRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NFTApi.Send: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The given ObitDID or USN argument | 
 **sendNFTRequest** | [**SendNFTRequest**](SendNFTRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Succesfully transfered |  -  |
| **404** | The requested resource could not be found. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateMetadata

> void UpdateMetadata (string key)

Update NFT metadata

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class UpdateMetadataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NFTApi(Configuration.Default);
            var key = did:obada:fe096095-e0f0-4918-9607-6567bd5756b5;  // string | The given ObitDID or USN argument

            try
            {
                // Update NFT metadata
                apiInstance.UpdateMetadata(key);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NFTApi.UpdateMetadata: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The given ObitDID or USN argument | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Metadata succesfully updated |  -  |
| **404** | The requested resource could not be found. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

