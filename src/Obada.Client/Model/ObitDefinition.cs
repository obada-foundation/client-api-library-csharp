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
using OpenAPIDateConverter = Obada.Client.Client.OpenAPIDateConverter;

namespace Obada.Client.Model
{
    /// <summary>
    /// ObitDefinition
    /// </summary>
    [DataContract]
    public partial class ObitDefinition :  IEquatable<ObitDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObitDefinition" /> class.
        /// </summary>
        /// <param name="serialHash">serialHash.</param>
        /// <param name="usn">usn.</param>
        /// <param name="obitDid">obitDid.</param>
        /// <param name="usnBase58">usnBase58.</param>
        public ObitDefinition(string serialHash = default(string), string usn = default(string), string obitDid = default(string), string usnBase58 = default(string))
        {
            this.SerialHash = serialHash;
            this.Usn = usn;
            this.ObitDid = obitDid;
            this.UsnBase58 = usnBase58;
        }

        /// <summary>
        /// Gets or Sets SerialHash
        /// </summary>
        [DataMember(Name="serial_hash", EmitDefaultValue=false)]
        public string SerialHash { get; set; }

        /// <summary>
        /// Gets or Sets Usn
        /// </summary>
        [DataMember(Name="usn", EmitDefaultValue=false)]
        public string Usn { get; set; }

        /// <summary>
        /// Gets or Sets ObitDid
        /// </summary>
        [DataMember(Name="obit_did", EmitDefaultValue=false)]
        public string ObitDid { get; set; }

        /// <summary>
        /// Gets or Sets UsnBase58
        /// </summary>
        [DataMember(Name="usn_base58", EmitDefaultValue=false)]
        public string UsnBase58 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObitDefinition {\n");
            sb.Append("  SerialHash: ").Append(SerialHash).Append("\n");
            sb.Append("  Usn: ").Append(Usn).Append("\n");
            sb.Append("  ObitDid: ").Append(ObitDid).Append("\n");
            sb.Append("  UsnBase58: ").Append(UsnBase58).Append("\n");
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
            return this.Equals(input as ObitDefinition);
        }

        /// <summary>
        /// Returns true if ObitDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of ObitDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObitDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SerialHash == input.SerialHash ||
                    (this.SerialHash != null &&
                    this.SerialHash.Equals(input.SerialHash))
                ) && 
                (
                    this.Usn == input.Usn ||
                    (this.Usn != null &&
                    this.Usn.Equals(input.Usn))
                ) && 
                (
                    this.ObitDid == input.ObitDid ||
                    (this.ObitDid != null &&
                    this.ObitDid.Equals(input.ObitDid))
                ) && 
                (
                    this.UsnBase58 == input.UsnBase58 ||
                    (this.UsnBase58 != null &&
                    this.UsnBase58.Equals(input.UsnBase58))
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
                if (this.SerialHash != null)
                    hashCode = hashCode * 59 + this.SerialHash.GetHashCode();
                if (this.Usn != null)
                    hashCode = hashCode * 59 + this.Usn.GetHashCode();
                if (this.ObitDid != null)
                    hashCode = hashCode * 59 + this.ObitDid.GetHashCode();
                if (this.UsnBase58 != null)
                    hashCode = hashCode * 59 + this.UsnBase58.GetHashCode();
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
