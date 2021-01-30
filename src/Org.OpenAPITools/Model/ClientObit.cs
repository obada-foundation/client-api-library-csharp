/* 
 * OBADA Client Helper API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.1
 * Contact: techops@obada.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ClientObit
    /// </summary>
    [DataContract]
    public partial class ClientObit :  IEquatable<ClientObit>, IValidatableObject
    {
        /// <summary>
        /// Represent available Obit statuses:   - FUNCTIONAL   - NON_FUNCTIONAL   - DISPOSED   - STOLEN   - DISABLED_BY_OWNER 
        /// </summary>
        /// <value>Represent available Obit statuses:   - FUNCTIONAL   - NON_FUNCTIONAL   - DISPOSED   - STOLEN   - DISABLED_BY_OWNER </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObitStatusEnum
        {
            /// <summary>
            /// Enum FUNCTIONAL for value: FUNCTIONAL
            /// </summary>
            [EnumMember(Value = "FUNCTIONAL")]
            FUNCTIONAL = 1,

            /// <summary>
            /// Enum NONFUNCTIONAL for value: NON_FUNCTIONAL
            /// </summary>
            [EnumMember(Value = "NON_FUNCTIONAL")]
            NONFUNCTIONAL = 2,

            /// <summary>
            /// Enum DISPOSED for value: DISPOSED
            /// </summary>
            [EnumMember(Value = "DISPOSED")]
            DISPOSED = 3,

            /// <summary>
            /// Enum STOLEN for value: STOLEN
            /// </summary>
            [EnumMember(Value = "STOLEN")]
            STOLEN = 4,

            /// <summary>
            /// Enum DISABLEDBYOWNER for value: DISABLED_BY_OWNER
            /// </summary>
            [EnumMember(Value = "DISABLED_BY_OWNER")]
            DISABLEDBYOWNER = 5

        }

        /// <summary>
        /// Represent available Obit statuses:   - FUNCTIONAL   - NON_FUNCTIONAL   - DISPOSED   - STOLEN   - DISABLED_BY_OWNER 
        /// </summary>
        /// <value>Represent available Obit statuses:   - FUNCTIONAL   - NON_FUNCTIONAL   - DISPOSED   - STOLEN   - DISABLED_BY_OWNER </value>
        [DataMember(Name="obit_status", EmitDefaultValue=false)]
        public ObitStatusEnum? ObitStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientObit" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="obitDid">obitDid.</param>
        /// <param name="usn">usn.</param>
        /// <param name="ownerDid">ownerDid.</param>
        /// <param name="obitStatus">Represent available Obit statuses:   - FUNCTIONAL   - NON_FUNCTIONAL   - DISPOSED   - STOLEN   - DISABLED_BY_OWNER .</param>
        /// <param name="manufacturer">manufacturer.</param>
        /// <param name="partNumber">partNumber.</param>
        /// <param name="serialNumberHash">serialNumberHash.</param>
        /// <param name="modifiedAt">modifiedAt.</param>
        /// <param name="rootHash">rootHash.</param>
        /// <param name="metadata">Get description from Rohi.</param>
        /// <param name="documents">To generate this link, take an SHA-256 hash of the document, and link to it as https://www.some-website.com?h1&#x3D;hash-of-document. Note this does not yet adhere to the hashlink standard. .</param>
        /// <param name="structuredData">Same as metadata but bigger. Key (string) &#x3D;&gt; Value (string) (hash per line sha256(key + value)).</param>
        public ClientObit(int id = default(int), string obitDid = default(string), string usn = default(string), string ownerDid = default(string), ObitStatusEnum? obitStatus = default(ObitStatusEnum?), string manufacturer = default(string), string partNumber = default(string), string serialNumberHash = default(string), DateTime modifiedAt = default(DateTime), string rootHash = default(string), List<LocalObitMetadata> metadata = default(List<LocalObitMetadata>), List<LocalObitDocuments> documents = default(List<LocalObitDocuments>), List<LocalObitStructuredData> structuredData = default(List<LocalObitStructuredData>))
        {
            this.Id = id;
            this.ObitDid = obitDid;
            this.Usn = usn;
            this.OwnerDid = ownerDid;
            this.ObitStatus = obitStatus;
            this.Manufacturer = manufacturer;
            this.PartNumber = partNumber;
            this.SerialNumberHash = serialNumberHash;
            this.ModifiedAt = modifiedAt;
            this.RootHash = rootHash;
            this.Metadata = metadata;
            this.Documents = documents;
            this.StructuredData = structuredData;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets ObitDid
        /// </summary>
        [DataMember(Name="obit_did", EmitDefaultValue=false)]
        public string ObitDid { get; set; }

        /// <summary>
        /// Gets or Sets Usn
        /// </summary>
        [DataMember(Name="usn", EmitDefaultValue=false)]
        public string Usn { get; set; }

        /// <summary>
        /// Gets or Sets OwnerDid
        /// </summary>
        [DataMember(Name="owner_did", EmitDefaultValue=false)]
        public string OwnerDid { get; set; }


        /// <summary>
        /// Gets or Sets Manufacturer
        /// </summary>
        [DataMember(Name="manufacturer", EmitDefaultValue=false)]
        public string Manufacturer { get; set; }

        /// <summary>
        /// Gets or Sets PartNumber
        /// </summary>
        [DataMember(Name="part_number", EmitDefaultValue=false)]
        public string PartNumber { get; set; }

        /// <summary>
        /// Gets or Sets SerialNumberHash
        /// </summary>
        [DataMember(Name="serial_number_hash", EmitDefaultValue=false)]
        public string SerialNumberHash { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedAt
        /// </summary>
        [DataMember(Name="modified_at", EmitDefaultValue=false)]
        public DateTime ModifiedAt { get; set; }

        /// <summary>
        /// Gets or Sets RootHash
        /// </summary>
        [DataMember(Name="root_hash", EmitDefaultValue=false)]
        public string RootHash { get; set; }

        /// <summary>
        /// Get description from Rohi
        /// </summary>
        /// <value>Get description from Rohi</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public List<LocalObitMetadata> Metadata { get; set; }

        /// <summary>
        /// To generate this link, take an SHA-256 hash of the document, and link to it as https://www.some-website.com?h1&#x3D;hash-of-document. Note this does not yet adhere to the hashlink standard. 
        /// </summary>
        /// <value>To generate this link, take an SHA-256 hash of the document, and link to it as https://www.some-website.com?h1&#x3D;hash-of-document. Note this does not yet adhere to the hashlink standard. </value>
        [DataMember(Name="documents", EmitDefaultValue=false)]
        public List<LocalObitDocuments> Documents { get; set; }

        /// <summary>
        /// Same as metadata but bigger. Key (string) &#x3D;&gt; Value (string) (hash per line sha256(key + value))
        /// </summary>
        /// <value>Same as metadata but bigger. Key (string) &#x3D;&gt; Value (string) (hash per line sha256(key + value))</value>
        [DataMember(Name="structured_data", EmitDefaultValue=false)]
        public List<LocalObitStructuredData> StructuredData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientObit {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ObitDid: ").Append(ObitDid).Append("\n");
            sb.Append("  Usn: ").Append(Usn).Append("\n");
            sb.Append("  OwnerDid: ").Append(OwnerDid).Append("\n");
            sb.Append("  ObitStatus: ").Append(ObitStatus).Append("\n");
            sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
            sb.Append("  PartNumber: ").Append(PartNumber).Append("\n");
            sb.Append("  SerialNumberHash: ").Append(SerialNumberHash).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  RootHash: ").Append(RootHash).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  StructuredData: ").Append(StructuredData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientObit);
        }

        /// <summary>
        /// Returns true if ClientObit instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientObit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientObit input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ObitDid == input.ObitDid ||
                    (this.ObitDid != null &&
                    this.ObitDid.Equals(input.ObitDid))
                ) && 
                (
                    this.Usn == input.Usn ||
                    (this.Usn != null &&
                    this.Usn.Equals(input.Usn))
                ) && 
                (
                    this.OwnerDid == input.OwnerDid ||
                    (this.OwnerDid != null &&
                    this.OwnerDid.Equals(input.OwnerDid))
                ) && 
                (
                    this.ObitStatus == input.ObitStatus ||
                    (this.ObitStatus != null &&
                    this.ObitStatus.Equals(input.ObitStatus))
                ) && 
                (
                    this.Manufacturer == input.Manufacturer ||
                    (this.Manufacturer != null &&
                    this.Manufacturer.Equals(input.Manufacturer))
                ) && 
                (
                    this.PartNumber == input.PartNumber ||
                    (this.PartNumber != null &&
                    this.PartNumber.Equals(input.PartNumber))
                ) && 
                (
                    this.SerialNumberHash == input.SerialNumberHash ||
                    (this.SerialNumberHash != null &&
                    this.SerialNumberHash.Equals(input.SerialNumberHash))
                ) && 
                (
                    this.ModifiedAt == input.ModifiedAt ||
                    (this.ModifiedAt != null &&
                    this.ModifiedAt.Equals(input.ModifiedAt))
                ) && 
                (
                    this.RootHash == input.RootHash ||
                    (this.RootHash != null &&
                    this.RootHash.Equals(input.RootHash))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.Documents == input.Documents ||
                    this.Documents != null &&
                    input.Documents != null &&
                    this.Documents.SequenceEqual(input.Documents)
                ) && 
                (
                    this.StructuredData == input.StructuredData ||
                    this.StructuredData != null &&
                    input.StructuredData != null &&
                    this.StructuredData.SequenceEqual(input.StructuredData)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ObitDid != null)
                    hashCode = hashCode * 59 + this.ObitDid.GetHashCode();
                if (this.Usn != null)
                    hashCode = hashCode * 59 + this.Usn.GetHashCode();
                if (this.OwnerDid != null)
                    hashCode = hashCode * 59 + this.OwnerDid.GetHashCode();
                if (this.ObitStatus != null)
                    hashCode = hashCode * 59 + this.ObitStatus.GetHashCode();
                if (this.Manufacturer != null)
                    hashCode = hashCode * 59 + this.Manufacturer.GetHashCode();
                if (this.PartNumber != null)
                    hashCode = hashCode * 59 + this.PartNumber.GetHashCode();
                if (this.SerialNumberHash != null)
                    hashCode = hashCode * 59 + this.SerialNumberHash.GetHashCode();
                if (this.ModifiedAt != null)
                    hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
                if (this.RootHash != null)
                    hashCode = hashCode * 59 + this.RootHash.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Documents != null)
                    hashCode = hashCode * 59 + this.Documents.GetHashCode();
                if (this.StructuredData != null)
                    hashCode = hashCode * 59 + this.StructuredData.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
