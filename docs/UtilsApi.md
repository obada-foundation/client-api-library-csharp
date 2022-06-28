# Obada.Client.Api.UtilsApi

All URIs are relative to *http://obs.node.obada.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GenerateChecksum**](UtilsApi.md#generatechecksum) | **POST** /obit/checksum | Generates Obit checksum
[**GenerateDID**](UtilsApi.md#generatedid) | **POST** /obit/did | Generate Obit DID



## GenerateChecksum

> GenerateObitChecksumResponse GenerateChecksum (GenerateObitChecksumRequest generateObitChecksumRequest = null)

Generates Obit checksum

Generates Obit checksum and provides a log of generation details

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class GenerateChecksumExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UtilsApi(Configuration.Default);
            var generateObitChecksumRequest = new GenerateObitChecksumRequest(); // GenerateObitChecksumRequest |  (optional) 

            try
            {
                // Generates Obit checksum
                GenerateObitChecksumResponse result = apiInstance.GenerateChecksum(generateObitChecksumRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UtilsApi.GenerateChecksum: " + e.Message );
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
 **generateObitChecksumRequest** | [**GenerateObitChecksumRequest**](GenerateObitChecksumRequest.md)|  | [optional] 

### Return type

[**GenerateObitChecksumResponse**](GenerateObitChecksumResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Obit checksum response |  -  |
| **422** | The submitted entity could not be processed. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GenerateDID

> GenerateObitDIDResponse GenerateDID (GenerateObitDIDRequest generateObitDIDRequest = null)

Generate Obit DID

Returns the Obit DID for a given device_id, part_number and serial_number input.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class GenerateDIDExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UtilsApi(Configuration.Default);
            var generateObitDIDRequest = new GenerateObitDIDRequest(); // GenerateObitDIDRequest |  (optional) 

            try
            {
                // Generate Obit DID
                GenerateObitDIDResponse result = apiInstance.GenerateDID(generateObitDIDRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UtilsApi.GenerateDID: " + e.Message );
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
 **generateObitDIDRequest** | [**GenerateObitDIDRequest**](GenerateObitDIDRequest.md)|  | [optional] 

### Return type

[**GenerateObitDIDResponse**](GenerateObitDIDResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Obit DID response |  -  |
| **422** | The submitted entity could not be processed. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

