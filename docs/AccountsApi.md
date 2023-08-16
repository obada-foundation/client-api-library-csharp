# Obada.Client.Api.AccountsApi

All URIs are relative to *http://obs.node.obada.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Account**](AccountsApi.md#account) | **GET** /accounts/{address} | Fetches an information about single account
[**Accounts**](AccountsApi.md#accounts) | **GET** /accounts | Returns a list of OBADA accounts
[**DeleteImportedAccount**](AccountsApi.md#deleteimportedaccount) | **DELETE** /accounts/{address} | Delete imported account
[**ExportAccount**](AccountsApi.md#exportaccount) | **POST** /accounts/export-account | Export OBADA account (private key) from client-helper
[**GetMnemonic**](AccountsApi.md#getmnemonic) | **GET** /accounts/mnemonic | Fetching an existing mnemonic phrase
[**ImportAccount**](AccountsApi.md#importaccount) | **POST** /accounts/import-account | Imports an existing OBADA account (private key) to the client-helper user profile
[**ImportWallet**](AccountsApi.md#importwallet) | **POST** /accounts/import-wallet | Imports an existing HD wallet to the client-helper user profile
[**NewAccount**](AccountsApi.md#newaccount) | **POST** /accounts/new-account | Creates a new OBADA account from HD wallet master key
[**NewMnemonic**](AccountsApi.md#newmnemonic) | **GET** /accounts/new-mnemonic | Generate a new mnemonic phrase for seeding wallet
[**NewWallet**](AccountsApi.md#newwallet) | **POST** /accounts/new-wallet | Creates profile HD wallet
[**Register**](AccountsApi.md#register) | **POST** /accounts/register | Register a new client-helper user profile
[**SendCoins**](AccountsApi.md#sendcoins) | **POST** /accounts/{address}/send-coins | Send coins from selected account
[**UpdateAccount**](AccountsApi.md#updateaccount) | **POST** /accounts/{address} | Sets account specific information



## Account

> Account Account (string address)

Fetches an information about single account

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class AccountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);
            var address = obada1yxxnd624tgwqm3eyv5smdvjrrydfh9h943qptg;  // string | OBADA address

            try
            {
                // Fetches an information about single account
                Account result = apiInstance.Account(address);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountsApi.Account: " + e.Message );
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
 **address** | **string**| OBADA address | 

### Return type

[**Account**](Account.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns OBADA account |  -  |
| **401** | The request is not authorized. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Accounts

> Accounts Accounts ()

Returns a list of OBADA accounts

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class AccountsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);

            try
            {
                // Returns a list of OBADA accounts
                Accounts result = apiInstance.Accounts();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountsApi.Accounts: " + e.Message );
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

[**Accounts**](Accounts.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns all OBADA accounts associated with client-helper profile |  -  |
| **401** | The request is not authorized. |  -  |
| **422** | The submitted entity could not be processed. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteImportedAccount

> void DeleteImportedAccount (string address)

Delete imported account

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class DeleteImportedAccountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);
            var address = obada1yxxnd624tgwqm3eyv5smdvjrrydfh9h943qptg;  // string | OBADA address

            try
            {
                // Delete imported account
                apiInstance.DeleteImportedAccount(address);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountsApi.DeleteImportedAccount: " + e.Message );
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
 **address** | **string**| OBADA address | 

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
| **204** | Account was deleted |  -  |
| **422** | The submitted entity could not be processed. |  -  |
| **401** | The request is not authorized. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ExportAccount

> ExportAccountResponse ExportAccount (ExportAccountRequest exportAccountRequest = null)

Export OBADA account (private key) from client-helper

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class ExportAccountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);
            var exportAccountRequest = new ExportAccountRequest(); // ExportAccountRequest |  (optional) 

            try
            {
                // Export OBADA account (private key) from client-helper
                ExportAccountResponse result = apiInstance.ExportAccount(exportAccountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountsApi.ExportAccount: " + e.Message );
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
 **exportAccountRequest** | [**ExportAccountRequest**](ExportAccountRequest.md)|  | [optional] 

### Return type

[**ExportAccountResponse**](ExportAccountResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Single OBADA account (private key) encrypted with password |  -  |
| **401** | The request is not authorized. |  -  |
| **409** |  |  -  |
| **422** | The submitted entity could not be processed. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetMnemonic

> NewMnemonic GetMnemonic ()

Fetching an existing mnemonic phrase

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class GetMnemonicExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);

            try
            {
                // Fetching an existing mnemonic phrase
                NewMnemonic result = apiInstance.GetMnemonic();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountsApi.GetMnemonic: " + e.Message );
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

[**NewMnemonic**](NewMnemonic.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New mnemonic phrase for wallet seeding |  -  |
| **401** | The request is not authorized. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ImportAccount

> void ImportAccount (ImportAccountRequest importAccountRequest = null)

Imports an existing OBADA account (private key) to the client-helper user profile

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class ImportAccountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);
            var importAccountRequest = new ImportAccountRequest(); // ImportAccountRequest |  (optional) 

            try
            {
                // Imports an existing OBADA account (private key) to the client-helper user profile
                apiInstance.ImportAccount(importAccountRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountsApi.ImportAccount: " + e.Message );
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
 **importAccountRequest** | [**ImportAccountRequest**](ImportAccountRequest.md)|  | [optional] 

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
| **201** | Account was imported |  -  |
| **401** | The request is not authorized. |  -  |
| **409** |  |  -  |
| **422** | The submitted entity could not be processed. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ImportWallet

> void ImportWallet (MnemonicRequest mnemonicRequest = null)

Imports an existing HD wallet to the client-helper user profile

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class ImportWalletExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);
            var mnemonicRequest = new MnemonicRequest(); // MnemonicRequest |  (optional) 

            try
            {
                // Imports an existing HD wallet to the client-helper user profile
                apiInstance.ImportWallet(mnemonicRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountsApi.ImportWallet: " + e.Message );
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
 **mnemonicRequest** | [**MnemonicRequest**](MnemonicRequest.md)|  | [optional] 

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
| **201** | HD wallet was imported |  -  |
| **401** | The request is not authorized. |  -  |
| **409** |  |  -  |
| **422** | The submitted entity could not be processed. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NewAccount

> void NewAccount (AccountRequest accountRequest = null)

Creates a new OBADA account from HD wallet master key

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class NewAccountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);
            var accountRequest = new AccountRequest(); // AccountRequest |  (optional) 

            try
            {
                // Creates a new OBADA account from HD wallet master key
                apiInstance.NewAccount(accountRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountsApi.NewAccount: " + e.Message );
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
 **accountRequest** | [**AccountRequest**](AccountRequest.md)|  | [optional] 

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
| **201** | Account was created |  -  |
| **401** | The request is not authorized. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NewMnemonic

> NewMnemonic NewMnemonic ()

Generate a new mnemonic phrase for seeding wallet

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class NewMnemonicExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);

            try
            {
                // Generate a new mnemonic phrase for seeding wallet
                NewMnemonic result = apiInstance.NewMnemonic();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountsApi.NewMnemonic: " + e.Message );
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

[**NewMnemonic**](NewMnemonic.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New mnemonic phrase for wallet seeding |  -  |
| **401** | The request is not authorized. |  -  |
| **422** | The submitted entity could not be processed. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NewWallet

> void NewWallet (MnemonicRequest mnemonicRequest = null)

Creates profile HD wallet

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class NewWalletExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);
            var mnemonicRequest = new MnemonicRequest(); // MnemonicRequest |  (optional) 

            try
            {
                // Creates profile HD wallet
                apiInstance.NewWallet(mnemonicRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountsApi.NewWallet: " + e.Message );
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
 **mnemonicRequest** | [**MnemonicRequest**](MnemonicRequest.md)|  | [optional] 

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
| **201** | HD wallet was created |  -  |
| **401** | The request is not authorized. |  -  |
| **422** | The submitted entity could not be processed. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Register

> Profile Register (RegisterRequest registerRequest = null)

Register a new client-helper user profile

Creates a new profile, using JWT uid as a internal user id

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class RegisterExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);
            var registerRequest = new RegisterRequest(); // RegisterRequest |  (optional) 

            try
            {
                // Register a new client-helper user profile
                Profile result = apiInstance.Register(registerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountsApi.Register: " + e.Message );
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
 **registerRequest** | [**RegisterRequest**](RegisterRequest.md)|  | [optional] 

### Return type

[**Profile**](Profile.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created profile response |  -  |
| **401** | The request is not authorized. |  -  |
| **422** | The submitted entity could not be processed. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SendCoins

> void SendCoins (string address, SendCoinsRequest sendCoinsRequest = null)

Send coins from selected account

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class SendCoinsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);
            var address = obada1yxxnd624tgwqm3eyv5smdvjrrydfh9h943qptg;  // string | OBADA address
            var sendCoinsRequest = new SendCoinsRequest(); // SendCoinsRequest |  (optional) 

            try
            {
                // Send coins from selected account
                apiInstance.SendCoins(address, sendCoinsRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountsApi.SendCoins: " + e.Message );
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
 **address** | **string**| OBADA address | 
 **sendCoinsRequest** | [**SendCoinsRequest**](SendCoinsRequest.md)|  | [optional] 

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
| **201** | Coins were sent |  -  |
| **401** | The request is not authorized. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateAccount

> void UpdateAccount (string address, AccountRequest accountRequest = null)

Sets account specific information

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Obada.Client.Api;
using Obada.Client.Client;
using Obada.Client.Model;

namespace Example
{
    public class UpdateAccountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://obs.node.obada.io";
            // Configure HTTP bearer authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);
            var address = obada1yxxnd624tgwqm3eyv5smdvjrrydfh9h943qptg;  // string | OBADA address
            var accountRequest = new AccountRequest(); // AccountRequest |  (optional) 

            try
            {
                // Sets account specific information
                apiInstance.UpdateAccount(address, accountRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountsApi.UpdateAccount: " + e.Message );
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
 **address** | **string**| OBADA address | 
 **accountRequest** | [**AccountRequest**](AccountRequest.md)|  | [optional] 

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
| **204** | Account was updated |  -  |
| **422** | The submitted entity could not be processed. |  -  |
| **401** | The request is not authorized. |  -  |
| **500** | Internal server error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

