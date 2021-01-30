# Obada.Client.Api.ObitApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadObitFromChain**](ObitApi.md#downloadobitfromchain) | **POST** /server/obit/download | Download Obit from Blockchain
[**FetchObitFromChain**](ObitApi.md#fetchobitfromchain) | **GET** /server/obit/{obit_did} | Get Obit From Blockchain
[**GenerateObitDef**](ObitApi.md#generateobitdef) | **GET** /obit/generate | Generate Obit Definition
[**GetClientObit**](ObitApi.md#getclientobit) | **GET** /client/obit/{obit_did} | Get Client Obit
[**SaveClientObit**](ObitApi.md#saveclientobit) | **POST** /client/obit | Save Client Obit
[**UploadObit**](ObitApi.md#uploadobit) | **POST** /server/obit/upload | Upload Obit to Blockchain



## DownloadObitFromChain

> ClientObitResponse DownloadObitFromChain (ObitDid obitDid = null)

Download Obit from Blockchain

Downloads the Obit information from the blockchain to the client.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class DownloadObitFromChainExample
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

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **obitDid** | [**ObitDid**](ObitDid.md)|  | [optional] 

### Return type

[**ClientObitResponse**](ClientObitResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the client obit downloaded from blockchain |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## FetchObitFromChain

> BlockChainObitResponse FetchObitFromChain (string obitDid)

Get Obit From Blockchain

Retrieves Obit information from blockchain but does not download it.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class FetchObitFromChainExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ObitApi(Configuration.Default);
            var obitDid = did:obada:81413bc1ad2074a6ae35d1f65f64f1bca2e8a20959f37ef0349a729ddc567d9b;  // string | Required.

            try
            {
                // Get Obit From Blockchain
                BlockChainObitResponse result = apiInstance.FetchObitFromChain(obitDid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.FetchObitFromChain: " + e.Message );
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
 **obitDid** | **string**| Required. | 

### Return type

[**BlockChainObitResponse**](BlockChainObitResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Array with ObitDID and USN Information |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GenerateObitDef

> ObitDefinitionResponse GenerateObitDef (string manufacturer, string partNumber, string serialNumber)

Generate Obit Definition

Returns the Obit Definition for a given device_id, part_number and serial_number input.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class GenerateObitDefExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ObitApi(Configuration.Default);
            var manufacturer = Apple;  // string | Device Id (Required)
            var partNumber = 123456789;  // string | Part Number (Required)
            var serialNumber = 123456789;  // string | Serial Number (Required)

            try
            {
                // Generate Obit Definition
                ObitDefinitionResponse result = apiInstance.GenerateObitDef(manufacturer, partNumber, serialNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.GenerateObitDef: " + e.Message );
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
 **manufacturer** | **string**| Device Id (Required) | 
 **partNumber** | **string**| Part Number (Required) | 
 **serialNumber** | **string**| Serial Number (Required) | 

### Return type

[**ObitDefinitionResponse**](ObitDefinitionResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the Obit Definition |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetClientObit

> ClientObitResponse GetClientObit (string obitDid)

Get Client Obit

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class GetClientObitExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ObitApi(Configuration.Default);
            var obitDid = did:obada:81413bc1ad2074a6ae35d1f65f64f1bca2e8a20959f37ef0349a729ddc567d9b;  // string | Required.

            try
            {
                // Get Client Obit
                ClientObitResponse result = apiInstance.GetClientObit(obitDid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.GetClientObit: " + e.Message );
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
 **obitDid** | **string**| Required. | 

### Return type

[**ClientObitResponse**](ClientObitResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the obit saved on the client |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SaveClientObit

> ClientObitResponse SaveClientObit (LocalObit localObit = null)

Save Client Obit

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class SaveClientObitExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ObitApi(Configuration.Default);
            var localObit = new LocalObit(); // LocalObit |  (optional) 

            try
            {
                // Save Client Obit
                ClientObitResponse result = apiInstance.SaveClientObit(localObit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.SaveClientObit: " + e.Message );
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
 **localObit** | [**LocalObit**](LocalObit.md)|  | [optional] 

### Return type

[**ClientObitResponse**](ClientObitResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the obit that was saved |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UploadObit

> BaseResponse UploadObit (ObitDid obitDid = null)

Upload Obit to Blockchain

Uploads Obit from client to the Blockchain

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class UploadObitExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ObitApi(Configuration.Default);
            var obitDid = new ObitDid(); // ObitDid |  (optional) 

            try
            {
                // Upload Obit to Blockchain
                BaseResponse result = apiInstance.UploadObit(obitDid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.UploadObit: " + e.Message );
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
 **obitDid** | [**ObitDid**](ObitDid.md)|  | [optional] 

### Return type

[**BaseResponse**](BaseResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a status of the operation |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

