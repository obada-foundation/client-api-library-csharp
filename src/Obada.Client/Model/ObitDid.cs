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
    /// ObitDid
    /// </summary>
    [DataContract]
    public partial class ObitDid :  IEquatable<ObitDid>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObitDid" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ObitDid() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ObitDid" /> class.
        /// </summary>
        /// <param name="obitDid">OBADA decentralized identifier (max length Rohi?) (required).</param>
        public ObitDid(string obitDid = default(string))
        {
            // to ensure "obitDid" is required (not null)
            if (obitDid == null)
            {
                throw new InvalidDataException("obitDid is a required property for ObitDid and cannot be null");
            }
            else
            {
                this._ObitDid = obitDid;
            }

        }

        /// <summary>
        /// OBADA decentralized identifier (max length Rohi?)
        /// </summary>
        /// <value>OBADA decentralized identifier (max length Rohi?)</value>
        [DataMember(Name="obit_did", EmitDefaultValue=true)]
        public string _ObitDid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObitDid {\n");
            sb.Append("  _ObitDid: ").Append(_ObitDid).Append("\n");
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
            return this.Equals(input as ObitDid);
        }

        /// <summary>
        /// Returns true if ObitDid instances are equal
        /// </summary>
        /// <param name="input">Instance of ObitDid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObitDid input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._ObitDid == input._ObitDid ||
                    (this._ObitDid != null &&
                    this._ObitDid.Equals(input._ObitDid))
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
                if (this._ObitDid != null)
                    hashCode = hashCode * 59 + this._ObitDid.GetHashCode();
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
            // _ObitDid (string) maxLength
            if(this._ObitDid != null && this._ObitDid.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for _ObitDid, length must be less than 256.", new [] { "_ObitDid" });
            }


            yield break;
        }
    }

}
