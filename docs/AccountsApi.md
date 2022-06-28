# Obada.Client.Api.AccountsApi

All URIs are relative to *http://obs.node.obada.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Balance**](AccountsApi.md#balance) | **GET** /accounts/my-balance | Shows account balance of OBADA address
[**CreateAccount**](AccountsApi.md#createaccount) | **POST** /accounts | Creates a new Account



## Balance

> AccountBalance Balance ()

Shows account balance of OBADA address

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class BalanceExample
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

### Parameters

This endpoint does not need any parameter.

### Return type

[**AccountBalance**](AccountBalance.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Account balance response |  -  |
| **401** | The request is not authorized. |  -  |
| **422** | The submitted entity could not be processed. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateAccount

> Account CreateAccount (NewAccountRequest newAccountRequest = null)

Creates a new Account

Creates a new account, using JWT uid as a internal user id

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class CreateAccountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);
            var newAccountRequest = new NewAccountRequest(); // NewAccountRequest |  (optional) 

            try
            {
                // Creates a new Account
                Account result = apiInstance.CreateAccount(newAccountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountsApi.CreateAccount: " + e.Message );
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
 **newAccountRequest** | [**NewAccountRequest**](NewAccountRequest.md)|  | [optional] 

### Return type

[**Account**](Account.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Create new Account response |  -  |
| **401** | The request is not authorized. |  -  |
| **422** | The submitted entity could not be processed. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

