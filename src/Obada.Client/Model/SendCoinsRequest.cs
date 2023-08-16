/*
 * OBADA API
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
    /// Sending tokens payload
    /// </summary>
    [DataContract]
    public partial class SendCoinsRequest :  IEquatable<SendCoinsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendCoinsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SendCoinsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendCoinsRequest" /> class.
        /// </summary>
        /// <param name="recepientAddress">recepientAddress (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="denom">denom (required).</param>
        public SendCoinsRequest(string recepientAddress = default(string), string amount = default(string), string denom = default(string))
        {
            // to ensure "recepientAddress" is required (not null)
            if (recepientAddress == null)
            {
                throw new InvalidDataException("recepientAddress is a required property for SendCoinsRequest and cannot be null");
            }
            else
            {
                this.RecepientAddress = recepientAddress;
            }

            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for SendCoinsRequest and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }

            // to ensure "denom" is required (not null)
            if (denom == null)
            {
                throw new InvalidDataException("denom is a required property for SendCoinsRequest and cannot be null");
            }
            else
            {
                this.Denom = denom;
            }

        }

        /// <summary>
        /// Gets or Sets RecepientAddress
        /// </summary>
        [DataMember(Name="recepient_address", EmitDefaultValue=true)]
        public string RecepientAddress { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets Denom
        /// </summary>
        [DataMember(Name="denom", EmitDefaultValue=true)]
        public string Denom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendCoinsRequest {\n");
            sb.Append("  RecepientAddress: ").Append(RecepientAddress).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Denom: ").Append(Denom).Append("\n");
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
            return this.Equals(input as SendCoinsRequest);
        }

        /// <summary>
        /// Returns true if SendCoinsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SendCoinsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendCoinsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecepientAddress == input.RecepientAddress ||
                    (this.RecepientAddress != null &&
                    this.RecepientAddress.Equals(input.RecepientAddress))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Denom == input.Denom ||
                    (this.Denom != null &&
                    this.Denom.Equals(input.Denom))
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
                if (this.RecepientAddress != null)
                    hashCode = hashCode * 59 + this.RecepientAddress.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Denom != null)
                    hashCode = hashCode * 59 + this.Denom.GetHashCode();
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