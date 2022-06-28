# Obada.Client.Api.ObitApi

All URIs are relative to *http://obs.node.obada.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](ObitApi.md#get) | **GET** /obits/{key} | Get Obit by DID or USN
[**History**](ObitApi.md#history) | **GET** /obits/{key}/history | Get Obit history by DID or USN
[**Save**](ObitApi.md#save) | **POST** /obits | Save Obit
[**Search**](ObitApi.md#search) | **GET** /obits | Search obits by query



## Get

> Obit Get (string key)

Get Obit by DID or USN

Get a single Obit by given ObitDID or USN

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class GetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ObitApi(Configuration.Default);
            var key = did:obada:fe096095-e0f0-4918-9607-6567bd5756b5;  // string | The given ObitDID or USN argument

            try
            {
                // Get Obit by DID or USN
                Obit result = apiInstance.Get(key);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.Get: " + e.Message );
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

[**Obit**](Obit.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **404** | The requested resource could not be found. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## History

> History200Response History (string key)

Get Obit history by DID or USN

Shows the history of changes by given Obit with ObitDID or USN

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class HistoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ObitApi(Configuration.Default);
            var key = did:obada:fe096095-e0f0-4918-9607-6567bd5756b5;  // string | The given ObitDID or USN argument

            try
            {
                // Get Obit history by DID or USN
                History200Response result = apiInstance.History(key);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.History: " + e.Message );
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

[**History200Response**](History200Response.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Collection of historical changes for given obit |  -  |
| **404** | The requested resource could not be found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Save

> Obit Save (SaveObitRequest saveObitRequest = null)

Save Obit

Returns Obit with updated checksum if data was changed.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class SaveExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ObitApi(Configuration.Default);
            var saveObitRequest = new SaveObitRequest(); // SaveObitRequest |  (optional) 

            try
            {
                // Save Obit
                Obit result = apiInstance.Save(saveObitRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.Save: " + e.Message );
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
 **saveObitRequest** | [**SaveObitRequest**](SaveObitRequest.md)|  | [optional] 

### Return type

[**Obit**](Obit.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json:
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **422** | The submitted entity could not be processed. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Search

> Obits Search (string q = null, int? offset = null)

Search obits by query

Implements a fulltext search for obits by \"searchTerm\".

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class SearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ObitApi(Configuration.Default);
            var q = fe403a1afe16203f4b8bb3a0e72d3e17567897bc15293e4a87b663e441030aea;  // string | Query argument that used for a fulltext search (optional) 
            var offset = 0;  // int? | Number of records to skip for pagination. (optional)  (default to 0)

            try
            {
                // Search obits by query
                Obits result = apiInstance.Search(q, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObitApi.Search: " + e.Message );
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
 **q** | **string**| Query argument that used for a fulltext search | [optional] 
 **offset** | **int?**| Number of records to skip for pagination. | [optional] [default to 0]

### Return type

[**Obits**](Obits.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of obits with pagination responded by given arguments. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

