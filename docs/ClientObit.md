
# Obada.Client.Model.ClientObit

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] 
**ObitDid** | **string** |  | [optional] 
**Usn** | **string** |  | [optional] 
**OwnerDid** | **string** |  | [optional] 
**ObitStatus** | **string** | Represent available Obit statuses:   - FUNCTIONAL   - NON_FUNCTIONAL   - DISPOSED   - STOLEN   - DISABLED_BY_OWNER  | [optional] 
**Manufacturer** | **string** |  | [optional] 
**PartNumber** | **string** |  | [optional] 
**SerialNumberHash** | **string** |  | [optional] 
**ModifiedAt** | **DateTime** |  | [optional] 
**RootHash** | **string** |  | [optional] 
**Metadata** | **Object** | Get description from Rohi | [optional] 
**Documents** | **Object** | To generate this link, take an SHA-256 hash of the document, and link to it as https://www.some-website.com?h1&#x3D;hash-of-document. Note this does not yet adhere to the hashlink standard.  | [optional] 
**StructuredData** | **Object** | Same as metadata but bigger. Key (string) &#x3D;&gt; Value (string) (hash per line sha256(key + value)) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

